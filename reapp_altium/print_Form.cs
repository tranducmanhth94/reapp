using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;

namespace reapp_altium
{
    public partial class print_form : Form
    {
        public print_form()
        {
            InitializeComponent();

          

        }

        private void print_form_Load(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument_PrintPage);
            //printDialog.ShowDialog(); // show ra ban lua chon in 
            printPreviewControl.Document = printDocument;

        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }


        }

      

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NTS株式会社", new Font("游明朝", 15, FontStyle.Bold), Brushes.Black, new Point(570, 10));
            e.Graphics.DrawString("プログラムのマンと申します。", new Font("游明朝", 15, FontStyle.Bold), Brushes.Black, new Point(500, 30));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(100, 60));

            e.Graphics.DrawString("試験結果", new Font("游明朝", 40, FontStyle.Bold), Brushes.Black, new Point(270, 120));

            e.Graphics.DrawString("1.試験条件", new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(20, 200));
            e.Graphics.DrawString("2.試験課題", new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(20, 220));
            e.Graphics.DrawString("3.試験結果表", new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(20, 240));

           



            e.Graphics.DrawString("_________________________________________________________", new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(100, 100));

            //最後

          
            //写真

            Image i = Image.FromFile(Application.StartupPath + "\\Resources\\job_avatar.png");
            Point p = new Point(1, 1);
            e.Graphics.DrawImage(i, 10, 10, 120, 120);


            // copy listview for printDocument 


            e.Graphics.DrawString("結果表", new Font("游明朝", 14, FontStyle.Bold), Brushes.Black, new Point(170, 270));
            //"ID    試験回数    ストローク     往復"
            e.Graphics.DrawString("ID", new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(170, 300));
            e.Graphics.DrawString("試験回数", new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(250, 300));
            e.Graphics.DrawString("ストローク", new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(350, 300));
            e.Graphics.DrawString("往復", new Font("游明朝", 12, FontStyle.Bold), Brushes.Black, new Point(470, 300));

            Font font = new Font("Arial", 12);
            float offset = e.MarginBounds.Top;
            
            // pageSize
            int pageSizeHeight = e.MarginBounds.Height; //969
            int pageSizeWeight = e.MarginBounds.Width;  //969

            int xSquare = 160;//190
            int ySquare = 330;//330

           
            int yword = 300;

            //item square
            Pen b = new Pen(Color.Black, 2);
            //square of word
            e.Graphics.DrawRectangle(b, xSquare , ySquare - 30 , 350, 30);



            ;
            int yLine = 330;
      

            // take item
            // pubic static then can use anthoer form



            for (int a = 0; a < automatic_form.frmobj.listViewConfig.Items.Count; a++)
            {
                //square of number
                e.Graphics.DrawRectangle(b, xSquare, ySquare  , 350, 30);
                ySquare = ySquare + 30;

                //write line 

                e.Graphics.DrawLine(b, 220, 390, 220, yLine);
                e.Graphics.DrawLine(b, 335, 390, 335, yLine);
                e.Graphics.DrawLine(b, 438, 390, 438, yLine);

                yLine = yLine + 45;


                // write word

                yword = yword + 32;
                int xword = 180;

                foreach (ListViewItem.ListViewSubItem Item in automatic_form.frmobj.listViewConfig.Items[a].SubItems)
                {
                  
                    e.Graphics.DrawString(Item.Text, font, Brushes.Black, xword, yword);
                    xword = xword + 100;
                                        
                }
              
            }

            //print grap

             Grap.objshare.Grap_power.SaveImage("grap", 0);

            Image image = Image.FromFile("grap");
            var ms = new MemoryStream();

            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            var bytes = ms.ToArray();

            var imageMemoryStream = new MemoryStream(bytes);
            Image imgFromStream = Image.FromStream(imageMemoryStream);

             e.Graphics.DrawImage(imgFromStream , new Point(10, 500));



            //// test item and subitems
            //int abc1 = automatic_form.frmobj.listViewConfig.Items.Count;
            //int anc2 = automatic_form.frmobj.listViewConfig.Items[0].SubItems.Count;


        }


    }
}
