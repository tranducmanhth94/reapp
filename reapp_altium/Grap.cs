using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroLibrary;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace reapp_altium
{
    public partial class Grap : Form
    {
        // use microLibrary
        public MicroLibrary.MicroTimer timer_eslaped;

        public struct PLCdevide
        {
            public string Device_type;
            public int Device_no;
        }

        // region PLC
        public static PLCdevide PLC_force_device;
        public static PLCdevide PLC_distance_device;

        public static double force, maxForce, distance, extX, extY ; // force

        public static double f_calibrated, f_calibrateForRange;

        // form parameter
        public static double dis_calibrated;

        // check noise disOld, disCur la khoang cach cu, hien tai
        double disOld = 0, disCur = 0, dif = 0;

        #region Variable for test

        double timer_chart;

        #endregion

        public Grap()
        {
            InitializeComponent();
            // Instantiate new MicroTimer and add event handler
            timer_eslaped = new MicroLibrary.MicroTimer();
            timer_eslaped.MicroTimerElapsed += new MicroLibrary.MicroTimer.MicroTimerElapsedEventHandler(OnTimedEvent);
            timer_eslaped.Interval = 100000; // Call micro timer every 1000µs (1ms)
                                           // Can choose to ignore event if late by Xµs (by default will try to catch up)
                                           // microTimer.IgnoreEventIfLateBy = 500; // 500µs (0.5ms)
            timer_eslaped.IgnoreEventIfLateBy = 2000;

            //Initial for Chart
            Grap_power.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            Grap_power.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
       

        }

        int max = 0;
        int value = 0;
        private void OnTimedEvent(object sender, MicroLibrary.MicroTimerEventArgs timerEventArgs)
        {
            // Do something small that takes significantly less time than Interval

            //int timer = 0;
            //timer = timer++;
            

            //  this is show count time by MANH
            Console.WriteLine(string.Format(
                "Count = {0:#,0}  Timer = {1:#,0} µs, " +
                "LateBy = {2:#,0} µs, ExecutionTime = {3:#,0} µs",
                timerEventArgs.TimerCount, timerEventArgs.ElapsedMicroseconds,
                timerEventArgs.TimerLateBy, timerEventArgs.CallbackFunctionExecutionTime));


            //  readTestData();

            // if(stop test condition)
            // timer_eslaped.Stop();

            // when add grapDATA must use
            

            BeginInvoke((MethodInvoker)delegate
            {

                Grap_power.Series[0].Points.AddXY(timerEventArgs.TimerCount, timerEventArgs.ElapsedMicroseconds);
                Grap_power.Series[1].Points.AddXY(timerEventArgs.CallbackFunctionExecutionTime, timerEventArgs.TimerCount);

                laB_load.Text = timerEventArgs.TimerCount.ToString();
                
                laB_distance.Text = timerEventArgs.CallbackFunctionExecutionTime.ToString();
                int current = (int)timerEventArgs.CallbackFunctionExecutionTime;
                
                
                if(current > max)
                {
                    max = current ;
                    laB_maxLoad.Text = max.ToString();
                }


            });

            value = timerEventArgs.TimerCount;
         }

        private void readTestData()
        {
            read_ForceDisEXT();
            
            //一応停止条件
            if(distance > 0)
            {
                timer_chart = timer_chart + Math.Round((double)timer_eslaped.Interval / 100000,3);
            }
           

        }

        private void read_ForceDisEXT()
        { 
            // FORCE
            // read word Low, High 
            int DmL = main_form.comM.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, PLC_force_device.Device_no.ToString());
            int DmH = 0; // doc gia tri 1 word // main_form.comM.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, PLC_force_device.Device_no + 1.ToString());

            // TEST readDevice dm10000 then can see force value is 0 -> 64000 then we need change for 2 singu int 16
            force = convert2Signedint16(DmL) * f_calibrated;

            DmL = main_form.comM.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "3002");
            maxForce = convert2Signedint16(DmL) * f_calibrated;

            //DISTANCE = distance of track(2 cục kéo)

            DmL = main_form.comM.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, PLC_distance_device.Device_no.ToString());
            DmH = main_form.comM.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, (PLC_distance_device.Device_no + 1).ToString());

            //check noise if khoang cach hien tai khac qua xa so voi khoang cach cu thi cho dung 
            disCur = convert2Signedint64(DmL, DmH) * dis_calibrated;
            if((Math.Abs(disCur - disOld)) < dif)
            {
                distance = disCur;
            }
            else
            {
                distance += (dif / 3);
                // check dif
            }

            // EXTENSOMETER
        }

        public double convert2Signedint64(Int64 a, Int64 b)
        {
            Int64 c = 0;
            c = a + b * 65536;
            if (c > 2147483647)
            {
                return (c - 4294967296);
            }
            else
                return c;
        }

        public int convert2Signedint16(int a)
        {
            if (a > 32767)
                return a - 65536;
            else
                return a;
        }
        int icount = 0;
        private void btn_StartGrap_Click(object sender, EventArgs e)
        {
     

            // Start timer
            timer_eslaped.Enabled = true;
            icount++;
            // Wait for user input
            // Console.ReadLine();
            if(icount > 1)
            {
                //icount = icount + 1;
                dataGridView_力.Columns.Add("headName", icount.ToString() + " 回目試験");
            }
            



        }

        private void btn_print1_Click(object sender, EventArgs e)
        {
            print_form manual = new print_form();
            this.Hide();
            manual.ShowDialog();
            this.Show();
        }

        private void btn_StopGrap_Click(object sender, EventArgs e)
        {
            // timer_power.Stop();

            timer_eslaped.Enabled = false;// Stop timer (executes asynchronously)

            int n = dataGridView_力.Columns.Count;

            dataGridView_力.Rows[0].Cells[n - 1].Value = value;
            dataGridView_力.Rows[1].Cells[n - 1].Value = value;
            dataGridView_力.Rows[2].Cells[n - 1].Value = value;

        }

        private void timer_power_Tick(object sender, EventArgs e)
        {
            int time = 0;
            time = time++;

         


        }
        // TRICK WHEN SHARE FORM
        // must change obj to public
        static Grap _formOBJ;
        public static Grap objshare
        {
            set { value = _formOBJ; }
            get { return _formOBJ; }
        }


        private void Grap_Load(object sender, EventArgs e)
        {
            _formOBJ = this;

            dataGridView_力.Columns.Add("headName", " 1回目試験");
            for(int i = 0; i < 2; i++ )
            {
                dataGridView_力.Rows.Add();
            
            }

            dataGridView_力.Rows[0].HeaderCell.Value = "試験名";
            dataGridView_力.Rows[1].HeaderCell.Value = "試験力";
            dataGridView_力.Rows[2].HeaderCell.Value = "試験今回";

            

        }


        

        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colIndex = dataGridView_力.CurrentCell.ColumnIndex;
            dataGridView_力.Columns.RemoveAt(colIndex);

            
            
        }
       

      

        private void 全データ削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("全データを削除しますか？","Errow" ,MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
           
            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView_力.Columns.Count; i++)
                {
                    this.dataGridView_力.Columns[i].Visible = false;

                }
            }

            icount = 0;
        }
       

    
    }
}
