
namespace reapp_altium
{
    partial class form_manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_manual));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.label_au = new System.Windows.Forms.Label();
            this.butStart2 = new System.Windows.Forms.Button();
            this.motorONorOFF = new System.Windows.Forms.TextBox();
            this.butStop1 = new System.Windows.Forms.Button();
            this.low_but = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.Button();
            this.high_but = new System.Windows.Forms.Button();
            this.but_Down = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "mm/s",
            "cm/s",
            "mm/m",
            "cm/m"});
            this.comboBox1.Location = new System.Drawing.Point(16, 213);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 20);
            this.comboBox1.TabIndex = 34;
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(28, 234);
            this.textBox_speed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(99, 19);
            this.textBox_speed.TabIndex = 33;
            // 
            // label_au
            // 
            this.label_au.AutoSize = true;
            this.label_au.Location = new System.Drawing.Point(7, 190);
            this.label_au.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_au.Name = "label_au";
            this.label_au.Size = new System.Drawing.Size(98, 12);
            this.label_au.TabIndex = 32;
            this.label_au.Text = "your choice speed";
            // 
            // butStart2
            // 
            this.butStart2.Location = new System.Drawing.Point(170, 37);
            this.butStart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butStart2.Name = "butStart2";
            this.butStart2.Size = new System.Drawing.Size(125, 33);
            this.butStart2.TabIndex = 31;
            this.butStart2.Text = "Start";
            this.butStart2.UseVisualStyleBackColor = true;
            this.butStart2.Click += new System.EventHandler(this.butStart2_Click);
            // 
            // motorONorOFF
            // 
            this.motorONorOFF.Location = new System.Drawing.Point(170, 90);
            this.motorONorOFF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.motorONorOFF.Name = "motorONorOFF";
            this.motorONorOFF.Size = new System.Drawing.Size(185, 19);
            this.motorONorOFF.TabIndex = 30;
            // 
            // butStop1
            // 
            this.butStop1.Location = new System.Drawing.Point(352, 37);
            this.butStop1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butStop1.Name = "butStop1";
            this.butStop1.Size = new System.Drawing.Size(113, 34);
            this.butStop1.TabIndex = 29;
            this.butStop1.Text = "Stop";
            this.butStop1.UseVisualStyleBackColor = true;
            this.butStop1.Click += new System.EventHandler(this.butStop1_Click);
            // 
            // low_but
            // 
            this.low_but.Location = new System.Drawing.Point(23, 128);
            this.low_but.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.low_but.Name = "low_but";
            this.low_but.Size = new System.Drawing.Size(103, 35);
            this.low_but.TabIndex = 28;
            this.low_but.Text = "LOW";
            this.low_but.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.Location = new System.Drawing.Point(23, 81);
            this.normal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(103, 34);
            this.normal.TabIndex = 27;
            this.normal.Text = "NORMAL";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // high_but
            // 
            this.high_but.Location = new System.Drawing.Point(23, 43);
            this.high_but.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.high_but.Name = "high_but";
            this.high_but.Size = new System.Drawing.Size(103, 28);
            this.high_but.TabIndex = 26;
            this.high_but.Text = "HIGH";
            this.high_but.UseVisualStyleBackColor = true;
            this.high_but.Click += new System.EventHandler(this.high_but_Click);
            // 
            // but_Down
            // 
            this.but_Down.Location = new System.Drawing.Point(261, 218);
            this.but_Down.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_Down.Name = "but_Down";
            this.but_Down.Size = new System.Drawing.Size(50, 46);
            this.but_Down.TabIndex = 25;
            this.but_Down.Text = "Down";
            this.but_Down.UseVisualStyleBackColor = true;
            this.but_Down.Click += new System.EventHandler(this.but_Down_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(318, 168);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(44, 40);
            this.buttonRight.TabIndex = 24;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(206, 168);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(46, 40);
            this.buttonLeft.TabIndex = 23;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Location = new System.Drawing.Point(261, 121);
            this.buttonUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(50, 38);
            this.buttonUP.TabIndex = 22;
            this.buttonUP.Text = "Up";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // form_manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_speed);
            this.Controls.Add(this.label_au);
            this.Controls.Add(this.butStart2);
            this.Controls.Add(this.motorONorOFF);
            this.Controls.Add(this.butStop1);
            this.Controls.Add(this.low_but);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.high_but);
            this.Controls.Add(this.but_Down);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_manual";
            this.Text = "Manual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.Label label_au;
        private System.Windows.Forms.Button butStart2;
        private System.Windows.Forms.TextBox motorONorOFF;
        private System.Windows.Forms.Button butStop1;
        private System.Windows.Forms.Button low_but;
        private System.Windows.Forms.Button normal;
        private System.Windows.Forms.Button high_but;
        private System.Windows.Forms.Button but_Down;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUP;
    }
}