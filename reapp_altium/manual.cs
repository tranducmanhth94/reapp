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

namespace reapp_altium
{
    public partial class form_manual : Form
    {
        public form_manual()
        {
            InitializeComponent();
        }

        private void butStop1_Click(object sender, EventArgs e)
        {
            if (main_form.comM.Active)
            {

                main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "1",1);
                //if (clickStop)
                //{
                //    comM.WriteDevice(DBPlcDevice.KV3000_MR, "001", 1);

                //}
                //else
                //{
                //    comM.WriteDevice(DBPlcDevice.KV3000_MR, "001", 0);
                //}
                motorONorOFF.Text = "you stopped robot";

                //clickStop = !clickStop;


            }
        }

        private void butStart2_Click(object sender, EventArgs e)
        {
            if (main_form.comM.Active)
            {
                main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "0", 1);

                //if (clickStart)
                //{
                //    comM.WriteDevice(DBPlcDevice.KV3000_MR, "000", 1);

                //}
                //else
                //    comM.WriteDevice(DBPlcDevice.KV3000_MR, "000", 0);
                motorONorOFF.Text = "OK, now you can control robot";

                // clickStart = !clickStart;
            }
        }

        private void high_but_Click(object sender, EventArgs e)
        {
            {
                if (main_form.comM.Active)
                    main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "", 1);
            }
            }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "", 1);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "", 1);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "", 1);
        }

        private void but_Down_Click(object sender, EventArgs e)
        {
            main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "", 1);
        }

    private void normal_Click(object sender, EventArgs e)
        {
            {
                if (main_form.comM.Active)
            {
                main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "", 1);
            }
            }
        }

        private void low_but_Click(object sender, EventArgs e)
        {
            if (main_form.comM.Active)
        {
            main_form.comM.WriteDevice(DBPlcDevice.KV3000_MR, "", 1);
        }
        }

   

        private void textBox_speed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (main_form.comM.Active)
            {
                    double valDouble = double.Parse(textBox_speed.Text) * 3.214;
                   
                    main_form.comM.WriteDevice(DBPlcDevice.DKV3000_CM,"2012",Convert.ToInt32(valDouble));
                }
            }

        }
    }
}
