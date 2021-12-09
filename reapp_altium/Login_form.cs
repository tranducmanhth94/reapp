using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reapp_altium
{
    public partial class Login_form : Form
    {
        public static bool login_check = false;
        public static string sql = "SELECT * From Account";
        public static DataTable dt;
        public static SqlDataAdapter adapter;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static ResourceManager rm;
        public static SqlDataReader dr;

        public static string userName, name;


        public Login_form()
        {
            InitializeComponent();
            // khai bao mo connect
            con = new SqlConnection();
            con.ConnectionString = @"data Source = (localdb)\mssqllocaldb;AttachDbFilename= |DataDirectory|\Database\接触database.mdf;Integrated Security = SSPI";
            con.Open();
              

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            //dr = new SqlDataReader();
            //adapter = new SqlDataAdapter("Select Count (*) From Account where username ='" + userName_txt.Text + "' and Password = '" + Password_txt.Text + "'", con);
            // count account and  
            cmd = new SqlCommand("Select *from Account where userName = @user and PassWord = @pass",con);
            cmd.Parameters.AddWithValue("@user", userName_txt.Text);
            cmd.Parameters.AddWithValue("@pass", Password_txt.Text);

            dr = cmd.ExecuteReader();

          
            
            if (dr.HasRows) // have value
            {
                
                main_form main = new main_form();
                this.Hide();
                main.ShowDialog();
                this.Show();

            }
            else
            {
                
                MessageBox.Show("login is fail, please check your id and password");

            }
            dr.Close();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("do you want exit?", "announce", MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK )
            {
                e.Cancel = true;
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
