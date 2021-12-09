using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATABUILDERAXLibLB;
using System.Diagnostics;
using System.Threading;
using System.IO;


namespace reapp_altium
{
    public partial class automatic_form : Form
    {
        
        DBTriggerManager triggerMangeer;
        //  DBTrigger trigger;
        DBTrigger triggerCounttimerALL;
        //DBTrigger triggerCounttimerOne;
        List<listType.testType> LISTcondition = new List<listType.testType>();

        public automatic_form()
        {
            InitializeComponent();

            listViewConfig.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listViewConfig.Columns.Add("試験回数", -2, HorizontalAlignment.Left);
            listViewConfig.Columns.Add("ストローク", -2, HorizontalAlignment.Left);
            listViewConfig.Columns.Add("往復", -2, HorizontalAlignment.Left);

            listViewConfig.View = View.Details;　// view listview


            triggerMangeer = new DATABUILDERAXLibLB.DBTriggerManager();
            
        }

        private void ON_Au_but_Click(object sender, EventArgs e)
        {
            main_form.comM.WriteDevice(DBPlcDevice.DKV3000_MR, "000", 1);
            label4.Text = "check for value";
            //foreach (Control c in this.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        TextBox textBox = c as TextBox;
            //        if (textBox.Text == string.Empty)
            //        {
            //            // Text box is empty.
            //            MessageBox.Show("Check value");
            //        }
            //    }
            //}

            if(string.IsNullOrWhiteSpace(txt_試験回数.Text)||string.IsNullOrWhiteSpace(txt_ストローク.Text)||string.IsNullOrWhiteSpace(txt_往復.Text))
            {
                MessageBox.Show("Check value");
            }
        }

        private void OFF_au_but_Click(object sender, EventArgs e)
        {
            main_form.comM.WriteDevice(DBPlcDevice.DKV3000_MR, "001", 1);
        }
       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               main_form.comM.WriteDevice(DBPlcDevice.DKV3000_DM, "500", Convert.ToInt32(txt_試験回数.Text));
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                main_form.comM.WriteDevice(DBPlcDevice.DKV3000_DM, "504", Convert.ToInt32(txt_ストローク.Text));
            }

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                main_form.comM.WriteDevice(DBPlcDevice.DKV3000_DM, "502", Convert.ToInt32(txt_往復.Text));
            }


        }
        int dm500 = 0;
        int dm502 = 0;
        int counter = 0;
        private System.Windows.Forms.Timer timer1;
        
        public void au_start_but_Click(object sender, EventArgs e)
        {

            // caculater for all time run
            int dm500 = main_form.comM.ReadDevice(DBPlcDevice.DKV3000_DM, "500");
            int dm502 = main_form.comM.ReadDevice(DBPlcDevice.DKV3000_DM, "502");

            txt_予算.Text = (dm500 * 60 / dm502).ToString();


            counter = dm500 * 60 / dm502;
        main_form.comM.WriteDevice(DBPlcDevice.DKV3000_MR, "003", 1);

            // trigger 

            triggerMangeer.Active = false;
            triggerMangeer.Triggers.Clear();

            // trigger mr6 up triggerDevice_fire move 

            triggerCounttimerALL = triggerMangeer.Triggers.Add(DBAxTriggerType.ttDevice);// add triggerCount for mangeer
            triggerCounttimerALL.AsDevice.CommManager = main_form.comM;
            triggerCounttimerALL.AsDevice.DeviceNo = "6";
            triggerCounttimerALL.AsDevice.DeviceCondition = 1;
            triggerCounttimerALL.AsDevice.DeviceKind = DATABUILDERAXLibLB.DBPlcDevice.DKV3000_MR;
            triggerCounttimerALL.Fire += triggerDeviceALL_Fire;

            //triggerCounttimerOne = triggerMangeer.Triggers.Add(DBAxTriggerType.ttDevice);
            //triggerCounttimerOne.AsDevice.CommManager = main_form.comM;
            //triggerCounttimerOne.AsDevice.DeviceNo = "5";
            //triggerCounttimerOne.AsDevice.DeviceCondition = 1;
            //triggerCounttimerOne.AsDevice.DeviceKind = DATABUILDERAXLibLB.DBPlcDevice.DKV3000_MR;
            //triggerCounttimerOne.Fire += triggerDeviceOne_Fire;


            triggerMangeer.Active = true;

            //reset i
            i = 2;

            //timer

            timer_試験.Start();


            // timer 1回

            stopwatch.Start();

            // countdown timer

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer_count_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            txt_残り.Text = counter.ToString();

        }

        Stopwatch stopwatch = new Stopwatch();
          int i = 2;
          int a = 0; // reset stopwatch
        
        private void triggerDeviceALL_Fire(DBTrigger dBTrigger)
        {

            int countALL = main_form.comM.ReadDevice(DBPlcDevice.DKV3000_CC, "0");
            textBox4.Text = countALL.ToString();

            if (countALL.ToString() == txt_試験回数.Text)
            {
                timer_試験.Stop();
            }

            for (int n = i; n <= countALL; n += 2)
            {
                stopwatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                txt_１回.Text = elapsedTime;
                stopwatch.Reset();


                stopwatch.Start();

                //MessageBox.Show("test mr6");
                i  = n + 2;
                 
            }

            // MessageBox.Show("test mr6");

        }

        //private void triggerDeviceOne_Fire(DBTrigger dBTrigger)
        //{
        //    int countOne = main_form.comM.ReadDevice(DBPlcDevice.DKV3000_CC, "0");
        //    for (int j = 3;j <= countOne; j+=2)
        //    {
        //        stopwatch.Start();
                
        //    }

        //}



        private void au_pause_but_Click(object sender, EventArgs e)
        {
            main_form.comM.WriteDevice(DBPlcDevice.DKV3000_MR, "004", 1);
            
        }

        private void au_reset_but_Click(object sender, EventArgs e)
        {
            main_form.comM.WriteDevice(DBPlcDevice.DKV3000_MR, "007", 1);
            textBox4.Text = string.Empty;
            txt_移動時間.Text = string.Empty;
            txt_残り.Text = string.Empty;
            txt_１回.Text = string.Empty;
            timer_試験.Stop();
            stopwatch.Stop();
            _timer = 0;

        }

        float _timer = 0.0f;
        private void timer1_Tick(object sender, EventArgs e)
        {

            _timer += (float)(timer_試験.Interval * 0.001);
            txt_移動時間.Text = _timer.ToString("0.00");

          
           
            

        }

        private void timer_count_Tick(object sender, EventArgs e)
        {
            // countdown 計算
            counter--;
            if (counter == 0)
                timer1.Stop();
            txt_残り.Text = counter.ToString();
        }

       


     
        private void save_but_Click(object sender, EventArgs e)
        {
           
            // check value


            // take data

            SaveFileDialog saveF = new SaveFileDialog();
            saveF.Filter = "Excel file (*.csv)|*.csv";
            if (saveF.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string[] cond = new string[LISTcondition.Count + 1];
                    cond[0] = "ID,試験回数,ストローク,往復";
                    for (int i = 0; i< LISTcondition.Count; i++ )
                    {
                        
                        cond[i+1] += LISTcondition[i].ID + "," + LISTcondition[i].試験回数 + "," + LISTcondition[i].ストローク.ToString() + "," + LISTcondition[i].往復.ToString();
                    }
                    File.WriteAllLines(saveF.FileName, cond , Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                

            }



        }


        private void config_btn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txt_試験回数.Text) || string.IsNullOrWhiteSpace(txt_往復.Text) || string.IsNullOrWhiteSpace(txt_ストローク.Text))
            {
                MessageBox.Show("Check value");
                return;
            }

            // tao truct xong luu vao list de tang dc ID len 1 gia tri
            // add vao listcondition

            listType.testType cd = new listType.testType();

            cd.試験回数 = Convert.ToInt32(txt_試験回数.Text);
            cd.ストローク = Convert.ToSingle(txt_ストローク.Text); // float
            cd.往復 = Convert.ToInt32(txt_往復.Text);
            cd.ID = LISTcondition.Count + 1;
            LISTcondition.Add(cd);



            // add vao listview

            string[] row = { cd.ID.ToString(),txt_試験回数.Text, txt_ストローク.Text, txt_往復.Text};
            var listViewItem = new ListViewItem(row);
            listViewConfig.Items.Add(listViewItem);







        }

        private void cmB_選択_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmB_選択.SelectedIndex; 
                    
            txt_試験回数.Text   = listViewConfig.Items[i].SubItems[1].Text;
            txt_ストローク.Text = listViewConfig.Items[i].SubItems[2].Text;
            txt_往復.Text       = listViewConfig.Items[i].SubItems[3].Text;
           



        }



        private void newFile_but_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                try
                {
                    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    openFileDialog1.DefaultExt = "csv";
                    openFileDialog1.Title = "Open file";
                    openFileDialog1.Filter = "CSV (*.csv)|*.csv";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileStream srcFS;
                        srcFS = new FileStream(openFileDialog1.FileName, FileMode.Open);
                        StreamReader srcSR = new StreamReader(srcFS, System.Text.Encoding.Default);

                        int count = 0;
                        do
                        {
                            count++;
                            string ins = srcSR.ReadLine();
                            if(count != 1)

                            
                            {
                                if (ins != null)
                                {
                                    string[] row = ins.Split(',');  // tach chuoi
                                    var listViewItem = new ListViewItem(row);
                                    listViewConfig.Items.Add(listViewItem);
                                    cmB_選択.Items.Add(row[0]);

                                                                     

                                }

                                else
                                {
                                    // = null out while
                                    break;
                                }

                            }                                                      
                         
                           
                        } while (true);


                        

                        srcSR.Close();
                    }
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message, "Error reading a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        　　

        }
    

        private void btn_PrintForm_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_Grap_Click(object sender, EventArgs e)
        {
            Grap grap_Form = new Grap();
            this.Hide();
            grap_Form.ShowDialog();
            this.Show();

        }

        // cach dung khi khong muon thay doi static
        // ĐẶC BIỆT NÊN XEM 
        //TRICK

        static automatic_form _formOBJ;
        public static automatic_form frmobj
        {
            set { value = _formOBJ; }
            get { return _formOBJ; }
        }

        private void automatic_form_Load(object sender, EventArgs e)
        {
            _formOBJ = this;
        }
    }
}
