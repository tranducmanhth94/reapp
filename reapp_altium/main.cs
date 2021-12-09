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
using System.Resources;
using System.Data.SqlClient;



namespace reapp_altium
{
   

    public partial class main_form : Form
    {
        public static DBCommManager comM;
        bool connect_check;
        public static DataTable dt;
        public static SqlDataAdapter adapter;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static ResourceManager rm;
        public static SqlDataReader dr;
        public static double Tempurture;
        public static double Humidity;
       

        public main_form()
        {
            InitializeComponent();

            LoadAccountList();

           // connect PLC
            comM = new DBCommManager();

            comM.Peer = "USB";
            comM.PLC = DBPlcId.DBPLC_DKV3000;

        }

        //public static void ConForPLC()
        //{
        //    comM = new DBCommManager();

        //    comM.Peer = "USB";
        //    comM.PLC = DBPlcId.DBPLC_DKV3000;


        //}
        private void main_form_Load(object sender, EventArgs e)
        {
            but_automatic.Hide();
            but_manual.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comM.Connect();
                connect_check = true;
                testcon_txt.Text = "connect success";

            }
            catch
            {
                connect_check = false;
                testcon_txt.Text = "connect fail, check for your connect";
            }
            finally
            { 

            }

            

            but_automatic.Show();
            but_manual.Show();
    
           
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (comM.Active)
        //        {
        //            comM.WriteDevice(DBPlcDevice.DKV3000_DM, "3000", Convert.ToInt32(textBox1.Text));
        //        }
        //    }
        //}

       

        private void dis_but_Click(object sender, EventArgs e)
        {
            comM.Disconnect();
            connect_check = false;
            testcon_txt.Text = "disconnected";
            
        }

        void LoadAccountList()
        {
            con = new SqlConnection();
            con.ConnectionString = @"data Source = (localdb)\mssqllocaldb;AttachDbFilename= |DataDirectory|\Database\接触database.mdf;Integrated Security = True";
            string query = "Select* from Account";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            
            adapter.Fill(dt);
            con.Close();
            dataAccountView.DataSource = dt;
        }

        // bool clickUP = false;
        //private void buttonUP_Click(object sender, EventArgs e)
        //{
        //    if(comM.Active)
        //    {
        //        if(clickUP)
        //        {
        //            comM.WriteDevice(DBPlcDevice.KV3000_MR, "300", 0);
        //        }
        //        else
        //        {
        //            comM.WriteDevice(DBPlcDevice.KV3000_MR, "300", 1);
        //        }
        //    }


        //    motorONorOFF.Text = "robot is go UP";
        //    clickUP = !clickUP;
        //}



        //bool clickStop = false;
      

        //List<string> SpeedIteam;



   

       

        private void funny_but_Click(object sender, EventArgs e)
        {
            Funny_form funny = new Funny_form();
            this.Hide();
            funny.ShowDialog();
            this.Show();
        }

        // cách viết để form khác dùng

        public static void changeData()
        {
            int a = addDLL温度計.TdTr73UCom_IsConnect();
            //no = a;
            //int show = addDLL温度計.TdTr73UCom_GetConctMachInfo(1, ref serialNo, ref macCode,  macName, 2);
            StringBuilder macName = new StringBuilder();
            uint serialNo = 1;
            short macCode = 1;

            int show = addDLL温度計.TdTr73UCom_GetConctMachInfo(0, ref serialNo, ref macCode, macName, 2);

            // serialNo  285230134
            // macCode   1096
            // macName   { TR - 73U}
            uint ch1Data = 1;
            uint ch2Data = 1;
            uint ch3Data = 1;

            int writeNhietdo = addDLL温度計.TdTr73UCom_GetCurrent(285230134, ref ch1Data, ref ch2Data, ref ch3Data, 2);

            Tempurture = (double)(ch1Data - 1000) / 10;
            Humidity = (ch2Data - 1000) / 10;

            
        }

        private void but_automatic_Click(object sender, EventArgs e)
        {
            automatic_form auto = new automatic_form();
            this.Hide();
            auto.ShowDialog();
            this.Show();
        }

        private void but_manual_Click(object sender, EventArgs e)
        {
            form_manual manual = new form_manual();
            this.Hide();
            manual.ShowDialog();
            this.Show();

        }

        private void btn_Camera_Click(object sender, EventArgs e)
        {
            form_Cam CAM = new form_Cam();
            this.Hide();
            CAM.ShowDialog();
            this.Show();

        }
    }
  
}
