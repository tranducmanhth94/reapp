using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reapp_altium
{
    public partial class Funny_form : Form
    {
        public Funny_form()
        {
            InitializeComponent();
          
        }

        private void takeTem_but_Click(object sender, EventArgs e)
        {
            main_form.changeData();
            txt_temperature.Text = main_form.Tempurture.ToString();
            txt_humidity.Text = main_form.Humidity.ToString();

            if (main_form.Tempurture < 28 && main_form.Humidity <= 65)
            {
                Lab_tenki.Text = "晴れ";
                picture_tem.Image = Image.FromFile(Application.StartupPath + "\\Resources\\晴れ.jpg");
            }
            else if (main_form.Tempurture > 28 && main_form.Humidity > 65)
            {
                Lab_tenki.Text = "雨、傘を忘れないで";
                picture_tem.Image = Image.FromFile(Application.StartupPath + "\\Resources\\あめ.jpg");
            }
            else
            {
                Lab_tenki.Text = "the end";
            }


        }

        private void history_but_Click(object sender, EventArgs e)
        {
           
            //DataTable dt = new DataTable();
            //dt.Clear();
            //dt.Columns.Add("Day");
            //dt.Columns.Add("Temperature");
            //dt.Columns.Add("Humidity");
            //DataRow his = dt.NewRow();
            //his["Day"] = "1";
            //his["Temperature"] = main_form.Tempurture.ToString();
            //his["Humidity"] = main_form.Humidity.ToString();
            //dt.Rows.Add(his);

            dataGridView1.Columns.Add("0", "Day");
            dataGridView1.Columns.Add("1", "Temp");
            dataGridView1.Columns.Add("2", "Hum");


            // creat table and start timer
            PauGrapHis = true;
            timer_tem.Start();

            history_but.Enabled = false;


        }

        private void timer_tem_Tick(object sender, EventArgs e)
        {
            

            if (PauGrapHis == true)
            {
                int time = 0;
                time = time++;
                main_form.changeData();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = DateTime.Now;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = main_form.Tempurture;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = main_form.Humidity;

                if (main_form.Tempurture < 28 && main_form.Humidity <= 65)
                {
                    Lab_tenki.Text = "the end";
                    
                }
                else if (main_form.Tempurture > 28 && main_form.Humidity > 65)
                {
                    Lab_tenki.Text = "雨、傘を忘れないで";
                    picture_tem.Image = Image.FromFile(Application.StartupPath + "\\Resources\\あめ.jpg");
                }
                else
                {
                    Lab_tenki.Text = "晴れ";
                    picture_tem.Image = Image.FromFile(Application.StartupPath + "\\Resources\\晴れ.jpg");

                }



                // creat grap

                if (disable == true)
                {
                    Grap_chart1.Series["Tem"].Points.AddXY(time, main_form.Tempurture);
                    Grap_chart1.Series["Hem"].Points.AddXY(time, main_form.Humidity);
                }


            }

        }
        bool disable = false;

        private void grap_but_Click(object sender, EventArgs e)
        {
            if(PauGrapHis == true)
            {
                disable = !disable;
                //chart title  
                Grap_chart1.Titles.Add("Grap_history");
            }

   
        }

        bool PauGrapHis = false;

        private void pause_but_Click(object sender, EventArgs e)
        {
            PauGrapHis = !PauGrapHis;
            history_but.Enabled = true;
        }

        private void take_Val_Click(object sender, EventArgs e)
        {
           if(dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV.(*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.Filter);

                        }
                        catch(IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the data to the disk." + ex.Message);
                        }
                    }
                    if(!fileError)
                    {
                        try
                        {
                            int cloumCount = dataGridView1.Columns.Count;
                            string cloumNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for(int i= 0; i< cloumCount;i++ )
                            {
                                cloumNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += cloumNames;

                            for(int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for(int j = 0; j < cloumCount; j ++)
                                {
                                    outputCsv[1] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
           else
            {
                MessageBox.Show("NO record to export !!!", "Info");
            }
               
            
        }


    }
}
