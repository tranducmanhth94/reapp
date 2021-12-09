
namespace reapp_altium
{
    partial class automatic_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(automatic_form));
            this.ON_Au_but = new System.Windows.Forms.Button();
            this.txt_試験回数 = new System.Windows.Forms.TextBox();
            this.txt_ストローク = new System.Windows.Forms.TextBox();
            this.txt_往復 = new System.Windows.Forms.TextBox();
            this.au_start_but = new System.Windows.Forms.Button();
            this.au_pause_but = new System.Windows.Forms.Button();
            this.au_reset_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OFF_au_but = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_移動時間 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_残り = new System.Windows.Forms.TextBox();
            this.timer_試験 = new System.Windows.Forms.Timer(this.components);
            this.lable8 = new System.Windows.Forms.Label();
            this.txt_１回 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_予算 = new System.Windows.Forms.TextBox();
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.newFile_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.confrim_but = new System.Windows.Forms.Button();
            this.cmB_選択 = new System.Windows.Forms.ComboBox();
            this.listViewConfig = new System.Windows.Forms.ListView();
            this.config_btn = new System.Windows.Forms.Button();
            this.btn_PrintForm = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_Grap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ON_Au_but
            // 
            this.ON_Au_but.Location = new System.Drawing.Point(251, 206);
            this.ON_Au_but.Margin = new System.Windows.Forms.Padding(2);
            this.ON_Au_but.Name = "ON_Au_but";
            this.ON_Au_but.Size = new System.Drawing.Size(85, 33);
            this.ON_Au_but.TabIndex = 0;
            this.ON_Au_but.Text = "ON";
            this.ON_Au_but.UseVisualStyleBackColor = true;
            this.ON_Au_but.Click += new System.EventHandler(this.ON_Au_but_Click);
            // 
            // txt_試験回数
            // 
            this.txt_試験回数.Location = new System.Drawing.Point(251, 42);
            this.txt_試験回数.Margin = new System.Windows.Forms.Padding(2);
            this.txt_試験回数.Name = "txt_試験回数";
            this.txt_試験回数.Size = new System.Drawing.Size(93, 19);
            this.txt_試験回数.TabIndex = 2;
            this.txt_試験回数.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txt_ストローク
            // 
            this.txt_ストローク.Location = new System.Drawing.Point(388, 42);
            this.txt_ストローク.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ストローク.Name = "txt_ストローク";
            this.txt_ストローク.Size = new System.Drawing.Size(98, 19);
            this.txt_ストローク.TabIndex = 3;
            this.txt_ストローク.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // txt_往復
            // 
            this.txt_往復.Location = new System.Drawing.Point(522, 42);
            this.txt_往復.Margin = new System.Windows.Forms.Padding(2);
            this.txt_往復.Name = "txt_往復";
            this.txt_往復.Size = new System.Drawing.Size(110, 19);
            this.txt_往復.TabIndex = 4;
            this.txt_往復.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // au_start_but
            // 
            this.au_start_but.Location = new System.Drawing.Point(251, 286);
            this.au_start_but.Margin = new System.Windows.Forms.Padding(2);
            this.au_start_but.Name = "au_start_but";
            this.au_start_but.Size = new System.Drawing.Size(74, 27);
            this.au_start_but.TabIndex = 5;
            this.au_start_but.Text = "Start";
            this.au_start_but.UseVisualStyleBackColor = true;
            this.au_start_but.Click += new System.EventHandler(this.au_start_but_Click);
            // 
            // au_pause_but
            // 
            this.au_pause_but.Location = new System.Drawing.Point(385, 290);
            this.au_pause_but.Margin = new System.Windows.Forms.Padding(2);
            this.au_pause_but.Name = "au_pause_but";
            this.au_pause_but.Size = new System.Drawing.Size(77, 25);
            this.au_pause_but.TabIndex = 6;
            this.au_pause_but.Text = "Pause";
            this.au_pause_but.UseVisualStyleBackColor = true;
            this.au_pause_but.Click += new System.EventHandler(this.au_pause_but_Click);
            // 
            // au_reset_but
            // 
            this.au_reset_but.Location = new System.Drawing.Point(522, 292);
            this.au_reset_but.Margin = new System.Windows.Forms.Padding(2);
            this.au_reset_but.Name = "au_reset_but";
            this.au_reset_but.Size = new System.Drawing.Size(81, 23);
            this.au_reset_but.TabIndex = 7;
            this.au_reset_but.Text = "Reset";
            this.au_reset_but.UseVisualStyleBackColor = true;
            this.au_reset_but.Click += new System.EventHandler(this.au_reset_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "試験回数(回)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "移動ストローク(mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "往復回数(回/min)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // OFF_au_but
            // 
            this.OFF_au_but.Location = new System.Drawing.Point(388, 206);
            this.OFF_au_but.Margin = new System.Windows.Forms.Padding(2);
            this.OFF_au_but.Name = "OFF_au_but";
            this.OFF_au_but.Size = new System.Drawing.Size(86, 28);
            this.OFF_au_but.TabIndex = 1;
            this.OFF_au_but.Text = "OFF";
            this.OFF_au_but.UseVisualStyleBackColor = true;
            this.OFF_au_but.Click += new System.EventHandler(this.OFF_au_but_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(251, 361);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 19);
            this.textBox4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "試験回数した(回)";
            // 
            // txt_移動時間
            // 
            this.txt_移動時間.Location = new System.Drawing.Point(388, 361);
            this.txt_移動時間.Margin = new System.Windows.Forms.Padding(2);
            this.txt_移動時間.Name = "txt_移動時間";
            this.txt_移動時間.Size = new System.Drawing.Size(105, 19);
            this.txt_移動時間.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "移動時間(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "残り時間(s)";
            // 
            // txt_残り
            // 
            this.txt_残り.Location = new System.Drawing.Point(522, 361);
            this.txt_残り.Margin = new System.Windows.Forms.Padding(2);
            this.txt_残り.Name = "txt_残り";
            this.txt_残り.Size = new System.Drawing.Size(86, 19);
            this.txt_残り.TabIndex = 17;
            // 
            // timer_試験
            // 
            this.timer_試験.Interval = 1000;
            this.timer_試験.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(386, 390);
            this.lable8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(87, 12);
            this.lable8.TabIndex = 18;
            this.lable8.Text = "１回移動時間(s)";
            // 
            // txt_１回
            // 
            this.txt_１回.Location = new System.Drawing.Point(388, 410);
            this.txt_１回.Margin = new System.Windows.Forms.Padding(2);
            this.txt_１回.Name = "txt_１回";
            this.txt_１回.Size = new System.Drawing.Size(102, 19);
            this.txt_１回.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "予算時間(s)";
            // 
            // txt_予算
            // 
            this.txt_予算.Location = new System.Drawing.Point(522, 410);
            this.txt_予算.Margin = new System.Windows.Forms.Padding(2);
            this.txt_予算.Name = "txt_予算";
            this.txt_予算.Size = new System.Drawing.Size(86, 19);
            this.txt_予算.TabIndex = 21;
            // 
            // timer_count
            // 
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // newFile_but
            // 
            this.newFile_but.Location = new System.Drawing.Point(246, 455);
            this.newFile_but.Name = "newFile_but";
            this.newFile_but.Size = new System.Drawing.Size(90, 30);
            this.newFile_but.TabIndex = 22;
            this.newFile_but.Text = "new file";
            this.newFile_but.UseVisualStyleBackColor = true;
            this.newFile_but.Click += new System.EventHandler(this.newFile_but_Click);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(384, 453);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(89, 32);
            this.save_but.TabIndex = 23;
            this.save_but.Text = "save file";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // confrim_but
            // 
            this.confrim_but.Location = new System.Drawing.Point(522, 453);
            this.confrim_but.Name = "confrim_but";
            this.confrim_but.Size = new System.Drawing.Size(93, 31);
            this.confrim_but.TabIndex = 24;
            this.confrim_but.Text = "confrim";
            this.confrim_but.UseVisualStyleBackColor = true;
            // 
            // cmB_選択
            // 
            this.cmB_選択.FormattingEnabled = true;
            this.cmB_選択.Location = new System.Drawing.Point(31, 41);
            this.cmB_選択.Name = "cmB_選択";
            this.cmB_選択.Size = new System.Drawing.Size(186, 20);
            this.cmB_選択.TabIndex = 25;
            this.cmB_選択.SelectedIndexChanged += new System.EventHandler(this.cmB_選択_SelectedIndexChanged);
            // 
            // listViewConfig
            // 
            this.listViewConfig.HideSelection = false;
            this.listViewConfig.Location = new System.Drawing.Point(31, 87);
            this.listViewConfig.Name = "listViewConfig";
            this.listViewConfig.Size = new System.Drawing.Size(186, 293);
            this.listViewConfig.TabIndex = 26;
            this.listViewConfig.UseCompatibleStateImageBehavior = false;
            // 
            // config_btn
            // 
            this.config_btn.Location = new System.Drawing.Point(664, 38);
            this.config_btn.Name = "config_btn";
            this.config_btn.Size = new System.Drawing.Size(75, 23);
            this.config_btn.TabIndex = 27;
            this.config_btn.Text = "config";
            this.config_btn.UseVisualStyleBackColor = true;
            this.config_btn.Click += new System.EventHandler(this.config_btn_Click);
            // 
            // btn_PrintForm
            // 
            this.btn_PrintForm.Location = new System.Drawing.Point(664, 139);
            this.btn_PrintForm.Name = "btn_PrintForm";
            this.btn_PrintForm.Size = new System.Drawing.Size(75, 30);
            this.btn_PrintForm.TabIndex = 28;
            this.btn_PrintForm.Text = "print Table";
            this.btn_PrintForm.UseVisualStyleBackColor = true;
            this.btn_PrintForm.Click += new System.EventHandler(this.btn_PrintForm_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btn_Grap
            // 
            this.btn_Grap.Location = new System.Drawing.Point(664, 87);
            this.btn_Grap.Name = "btn_Grap";
            this.btn_Grap.Size = new System.Drawing.Size(75, 23);
            this.btn_Grap.TabIndex = 29;
            this.btn_Grap.Text = "Grap";
            this.btn_Grap.UseVisualStyleBackColor = true;
            this.btn_Grap.Click += new System.EventHandler(this.btn_Grap_Click);
            // 
            // automatic_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(799, 634);
            this.Controls.Add(this.btn_Grap);
            this.Controls.Add(this.btn_PrintForm);
            this.Controls.Add(this.config_btn);
            this.Controls.Add(this.listViewConfig);
            this.Controls.Add(this.cmB_選択);
            this.Controls.Add(this.confrim_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.newFile_but);
            this.Controls.Add(this.txt_予算);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_１回);
            this.Controls.Add(this.lable8);
            this.Controls.Add(this.txt_残り);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_移動時間);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.OFF_au_but);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.au_reset_but);
            this.Controls.Add(this.au_pause_but);
            this.Controls.Add(this.au_start_but);
            this.Controls.Add(this.txt_往復);
            this.Controls.Add(this.txt_ストローク);
            this.Controls.Add(this.txt_試験回数);
            this.Controls.Add(this.ON_Au_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "automatic_form";
            this.Text = "Automatic";
            this.Load += new System.EventHandler(this.automatic_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ON_Au_but;
        private System.Windows.Forms.TextBox txt_試験回数;
        private System.Windows.Forms.TextBox txt_ストローク;
        private System.Windows.Forms.TextBox txt_往復;
        private System.Windows.Forms.Button au_start_but;
        private System.Windows.Forms.Button au_pause_but;
        private System.Windows.Forms.Button au_reset_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OFF_au_but;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_移動時間;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_残り;
        private System.Windows.Forms.Timer timer_試験;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.TextBox txt_１回;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_予算;
        private System.Windows.Forms.Timer timer_count;
        private System.Windows.Forms.Button newFile_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Button confrim_but;
        private System.Windows.Forms.Button config_btn;
        private System.Windows.Forms.Button btn_PrintForm;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_Grap;
        public System.Windows.Forms.ListView listViewConfig;
        public System.Windows.Forms.ComboBox cmB_選択;
    }
}