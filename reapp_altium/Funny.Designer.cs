
namespace reapp_altium
{
    partial class Funny_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funny_form));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_humidity = new System.Windows.Forms.TextBox();
            this.txt_temperature = new System.Windows.Forms.TextBox();
            this.takeTem_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.history_but = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer_tem = new System.Windows.Forms.Timer(this.components);
            this.grap_but = new System.Windows.Forms.Button();
            this.Grap_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.take_Val = new System.Windows.Forms.Button();
            this.pause_but = new System.Windows.Forms.Button();
            this.Lab_tenki = new System.Windows.Forms.Label();
            this.picture_tem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grap_chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tem)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "humidity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "temperature";
            // 
            // txt_humidity
            // 
            this.txt_humidity.Location = new System.Drawing.Point(179, 77);
            this.txt_humidity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_humidity.Name = "txt_humidity";
            this.txt_humidity.Size = new System.Drawing.Size(57, 19);
            this.txt_humidity.TabIndex = 20;
            // 
            // txt_temperature
            // 
            this.txt_temperature.Location = new System.Drawing.Point(66, 78);
            this.txt_temperature.Margin = new System.Windows.Forms.Padding(2);
            this.txt_temperature.Name = "txt_temperature";
            this.txt_temperature.Size = new System.Drawing.Size(65, 19);
            this.txt_temperature.TabIndex = 19;
            // 
            // takeTem_but
            // 
            this.takeTem_but.Location = new System.Drawing.Point(21, 15);
            this.takeTem_but.Margin = new System.Windows.Forms.Padding(2);
            this.takeTem_but.Name = "takeTem_but";
            this.takeTem_but.Size = new System.Drawing.Size(81, 30);
            this.takeTem_but.TabIndex = 0;
            this.takeTem_but.Text = "See_now";
            this.takeTem_but.UseVisualStyleBackColor = true;
            this.takeTem_but.Click += new System.EventHandler(this.takeTem_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(133, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "°C ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "%";
            // 
            // history_but
            // 
            this.history_but.Location = new System.Drawing.Point(134, 114);
            this.history_but.Margin = new System.Windows.Forms.Padding(2);
            this.history_but.Name = "history_but";
            this.history_but.Size = new System.Drawing.Size(108, 29);
            this.history_but.TabIndex = 25;
            this.history_but.Text = "history";
            this.history_but.UseVisualStyleBackColor = true;
            this.history_but.Click += new System.EventHandler(this.history_but_Click);
          //  this.history_but.MouseClick += new System.Windows.Forms.MouseEventHandler(this.history_but_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(335, 170);
            this.dataGridView1.TabIndex = 26;
            // 
            // timer_tem
            // 
            this.timer_tem.Interval = 3000;
            this.timer_tem.Tick += new System.EventHandler(this.timer_tem_Tick);
            // 
            // grap_but
            // 
            this.grap_but.Location = new System.Drawing.Point(448, 114);
            this.grap_but.Margin = new System.Windows.Forms.Padding(2);
            this.grap_but.Name = "grap_but";
            this.grap_but.Size = new System.Drawing.Size(105, 29);
            this.grap_but.TabIndex = 27;
            this.grap_but.Text = "Graph";
            this.grap_but.UseVisualStyleBackColor = true;
            this.grap_but.Click += new System.EventHandler(this.grap_but_Click);
            // 
            // Grap_chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Grap_chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grap_chart1.Legends.Add(legend1);
            this.Grap_chart1.Location = new System.Drawing.Point(359, 147);
            this.Grap_chart1.Margin = new System.Windows.Forms.Padding(2);
            this.Grap_chart1.Name = "Grap_chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Tem";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Hem";
            this.Grap_chart1.Series.Add(series1);
            this.Grap_chart1.Series.Add(series2);
            this.Grap_chart1.Size = new System.Drawing.Size(292, 170);
            this.Grap_chart1.TabIndex = 28;
            this.Grap_chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "now";
            // 
            // take_Val
            // 
            this.take_Val.Location = new System.Drawing.Point(194, 15);
            this.take_Val.Margin = new System.Windows.Forms.Padding(2);
            this.take_Val.Name = "take_Val";
            this.take_Val.Size = new System.Drawing.Size(78, 30);
            this.take_Val.TabIndex = 31;
            this.take_Val.Text = "Take_Val";
            this.take_Val.UseVisualStyleBackColor = true;
            this.take_Val.Click += new System.EventHandler(this.take_Val_Click);
            // 
            // pause_but
            // 
            this.pause_but.Location = new System.Drawing.Point(111, 15);
            this.pause_but.Margin = new System.Windows.Forms.Padding(2);
            this.pause_but.Name = "pause_but";
            this.pause_but.Size = new System.Drawing.Size(70, 30);
            this.pause_but.TabIndex = 32;
            this.pause_but.Text = "Pause";
            this.pause_but.UseVisualStyleBackColor = true;
            this.pause_but.Click += new System.EventHandler(this.pause_but_Click);
            // 
            // Lab_tenki
            // 
            this.Lab_tenki.AutoSize = true;
            this.Lab_tenki.Location = new System.Drawing.Point(436, 41);
            this.Lab_tenki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_tenki.Name = "Lab_tenki";
            this.Lab_tenki.Size = new System.Drawing.Size(35, 12);
            this.Lab_tenki.TabIndex = 33;
            this.Lab_tenki.Text = "label6";
            // 
            // picture_tem
            // 
            this.picture_tem.Image = global::reapp_altium.Properties.Resources.あめ;
            this.picture_tem.Location = new System.Drawing.Point(325, 15);
            this.picture_tem.Margin = new System.Windows.Forms.Padding(2);
            this.picture_tem.Name = "picture_tem";
            this.picture_tem.Size = new System.Drawing.Size(99, 68);
            this.picture_tem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_tem.TabIndex = 30;
            this.picture_tem.TabStop = false;
            // 
            // Funny_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(673, 351);
            this.Controls.Add(this.Lab_tenki);
            this.Controls.Add(this.pause_but);
            this.Controls.Add(this.take_Val);
            this.Controls.Add(this.picture_tem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Grap_chart1);
            this.Controls.Add(this.grap_but);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.history_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.takeTem_but);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_humidity);
            this.Controls.Add(this.txt_temperature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Funny_form";
            this.Text = "Fuuny";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grap_chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_humidity;
        private System.Windows.Forms.TextBox txt_temperature;
        private System.Windows.Forms.Button takeTem_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button history_but;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer_tem;
        private System.Windows.Forms.Button grap_but;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grap_chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture_tem;
        private System.Windows.Forms.Button take_Val;
        private System.Windows.Forms.Button pause_but;
        private System.Windows.Forms.Label Lab_tenki;
    }
}