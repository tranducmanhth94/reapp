
namespace reapp_altium
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new reapp_altium.DataSet1();
            this.FunnyPage = new System.Windows.Forms.TabPage();
            this.funny_but = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.TabPage();
            this.dataAccountView = new System.Windows.Forms.DataGridView();
            this.tabconnect = new System.Windows.Forms.TabPage();
            this.btn_Camera = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_manual = new System.Windows.Forms.Button();
            this.but_automatic = new System.Windows.Forms.Button();
            this.dis_but = new System.Windows.Forms.Button();
            this.handtest = new System.Windows.Forms.CheckBox();
            this.seeTEST = new System.Windows.Forms.CheckBox();
            this.testcon_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.con_but = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.FunnyPage.SuspendLayout();
            this.account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountView)).BeginInit();
            this.tabconnect.SuspendLayout();
            this.welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.seeToolStripMenuItem,
            this.lookToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // seeToolStripMenuItem
            // 
            this.seeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.seeToolStripMenuItem.Name = "seeToolStripMenuItem";
            this.seeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.seeToolStripMenuItem.Text = "see";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "1";
            // 
            // lookToolStripMenuItem
            // 
            this.lookToolStripMenuItem.Name = "lookToolStripMenuItem";
            this.lookToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.lookToolStripMenuItem.Text = "look";
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FunnyPage
            // 
            this.FunnyPage.Controls.Add(this.funny_but);
            this.FunnyPage.Location = new System.Drawing.Point(4, 22);
            this.FunnyPage.Margin = new System.Windows.Forms.Padding(2);
            this.FunnyPage.Name = "FunnyPage";
            this.FunnyPage.Padding = new System.Windows.Forms.Padding(2);
            this.FunnyPage.Size = new System.Drawing.Size(545, 305);
            this.FunnyPage.TabIndex = 3;
            this.FunnyPage.Text = "Funny";
            this.FunnyPage.UseVisualStyleBackColor = true;
            // 
            // funny_but
            // 
            this.funny_but.Location = new System.Drawing.Point(154, 75);
            this.funny_but.Margin = new System.Windows.Forms.Padding(2);
            this.funny_but.Name = "funny_but";
            this.funny_but.Size = new System.Drawing.Size(245, 68);
            this.funny_but.TabIndex = 0;
            this.funny_but.Text = "楽しみ";
            this.funny_but.UseVisualStyleBackColor = true;
            this.funny_but.Click += new System.EventHandler(this.funny_but_Click);
            // 
            // account
            // 
            this.account.Controls.Add(this.dataAccountView);
            this.account.Location = new System.Drawing.Point(4, 22);
            this.account.Margin = new System.Windows.Forms.Padding(2);
            this.account.Name = "account";
            this.account.Padding = new System.Windows.Forms.Padding(2);
            this.account.Size = new System.Drawing.Size(545, 305);
            this.account.TabIndex = 2;
            this.account.Text = "account";
            this.account.UseVisualStyleBackColor = true;
            // 
            // dataAccountView
            // 
            this.dataAccountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccountView.Location = new System.Drawing.Point(0, 4);
            this.dataAccountView.Margin = new System.Windows.Forms.Padding(2);
            this.dataAccountView.Name = "dataAccountView";
            this.dataAccountView.RowHeadersWidth = 62;
            this.dataAccountView.RowTemplate.Height = 27;
            this.dataAccountView.Size = new System.Drawing.Size(383, 241);
            this.dataAccountView.TabIndex = 0;
            // 
            // tabconnect
            // 
            this.tabconnect.ContextMenuStrip = this.contextMenuStrip1;
            this.tabconnect.Controls.Add(this.btn_Camera);
            this.tabconnect.Controls.Add(this.button1);
            this.tabconnect.Controls.Add(this.but_manual);
            this.tabconnect.Controls.Add(this.but_automatic);
            this.tabconnect.Controls.Add(this.dis_but);
            this.tabconnect.Controls.Add(this.handtest);
            this.tabconnect.Controls.Add(this.seeTEST);
            this.tabconnect.Controls.Add(this.testcon_txt);
            this.tabconnect.Controls.Add(this.dateTimePicker1);
            this.tabconnect.Controls.Add(this.label2);
            this.tabconnect.Controls.Add(this.con_but);
            this.tabconnect.Location = new System.Drawing.Point(4, 22);
            this.tabconnect.Margin = new System.Windows.Forms.Padding(2);
            this.tabconnect.Name = "tabconnect";
            this.tabconnect.Padding = new System.Windows.Forms.Padding(2);
            this.tabconnect.Size = new System.Drawing.Size(545, 305);
            this.tabconnect.TabIndex = 0;
            this.tabconnect.Text = "connect";
            this.tabconnect.UseVisualStyleBackColor = true;
            // 
            // btn_Camera
            // 
            this.btn_Camera.Location = new System.Drawing.Point(386, 194);
            this.btn_Camera.Name = "btn_Camera";
            this.btn_Camera.Size = new System.Drawing.Size(89, 33);
            this.btn_Camera.TabIndex = 16;
            this.btn_Camera.Text = "Camera";
            this.btn_Camera.UseVisualStyleBackColor = true;
            this.btn_Camera.Click += new System.EventHandler(this.btn_Camera_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // but_manual
            // 
            this.but_manual.Location = new System.Drawing.Point(386, 126);
            this.but_manual.Margin = new System.Windows.Forms.Padding(2);
            this.but_manual.Name = "but_manual";
            this.but_manual.Size = new System.Drawing.Size(89, 36);
            this.but_manual.TabIndex = 14;
            this.but_manual.Text = "Manual";
            this.but_manual.UseVisualStyleBackColor = true;
            this.but_manual.Click += new System.EventHandler(this.but_manual_Click);
            // 
            // but_automatic
            // 
            this.but_automatic.Location = new System.Drawing.Point(386, 64);
            this.but_automatic.Margin = new System.Windows.Forms.Padding(2);
            this.but_automatic.Name = "but_automatic";
            this.but_automatic.Size = new System.Drawing.Size(89, 37);
            this.but_automatic.TabIndex = 13;
            this.but_automatic.Text = "Automatic";
            this.but_automatic.UseVisualStyleBackColor = true;
            this.but_automatic.Click += new System.EventHandler(this.but_automatic_Click);
            // 
            // dis_but
            // 
            this.dis_but.Location = new System.Drawing.Point(17, 101);
            this.dis_but.Margin = new System.Windows.Forms.Padding(2);
            this.dis_but.Name = "dis_but";
            this.dis_but.Size = new System.Drawing.Size(71, 32);
            this.dis_but.TabIndex = 12;
            this.dis_but.Text = "disconnect";
            this.dis_but.UseVisualStyleBackColor = true;
            this.dis_but.Click += new System.EventHandler(this.dis_but_Click);
            // 
            // handtest
            // 
            this.handtest.AutoSize = true;
            this.handtest.Location = new System.Drawing.Point(136, 183);
            this.handtest.Margin = new System.Windows.Forms.Padding(2);
            this.handtest.Name = "handtest";
            this.handtest.Size = new System.Drawing.Size(135, 16);
            this.handtest.TabIndex = 11;
            this.handtest.Text = "check safe for human";
            this.handtest.UseVisualStyleBackColor = true;
            // 
            // seeTEST
            // 
            this.seeTEST.AutoSize = true;
            this.seeTEST.Location = new System.Drawing.Point(136, 147);
            this.seeTEST.Margin = new System.Windows.Forms.Padding(2);
            this.seeTEST.Name = "seeTEST";
            this.seeTEST.Size = new System.Drawing.Size(144, 16);
            this.seeTEST.TabIndex = 10;
            this.seeTEST.Text = "check state of machine";
            this.seeTEST.UseVisualStyleBackColor = true;
            // 
            // testcon_txt
            // 
            this.testcon_txt.Location = new System.Drawing.Point(136, 85);
            this.testcon_txt.Margin = new System.Windows.Forms.Padding(2);
            this.testcon_txt.Name = "testcon_txt";
            this.testcon_txt.Size = new System.Drawing.Size(222, 19);
            this.testcon_txt.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 7);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 19);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "検査日";
            // 
            // con_but
            // 
            this.con_but.Location = new System.Drawing.Point(17, 53);
            this.con_but.Margin = new System.Windows.Forms.Padding(2);
            this.con_but.Name = "con_but";
            this.con_but.Size = new System.Drawing.Size(71, 36);
            this.con_but.TabIndex = 2;
            this.con_but.Text = "connect";
            this.con_but.UseVisualStyleBackColor = true;
            this.con_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcome
            // 
            this.welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome.Controls.Add(this.tabconnect);
            this.welcome.Controls.Add(this.account);
            this.welcome.Controls.Add(this.FunnyPage);
            this.welcome.Location = new System.Drawing.Point(11, 5);
            this.welcome.Margin = new System.Windows.Forms.Padding(2);
            this.welcome.Name = "welcome";
            this.welcome.SelectedIndex = 0;
            this.welcome.Size = new System.Drawing.Size(553, 331);
            this.welcome.TabIndex = 9;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 347);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main_form";
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.FunnyPage.ResumeLayout(false);
            this.account.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountView)).EndInit();
            this.tabconnect.ResumeLayout(false);
            this.tabconnect.PerformLayout();
            this.welcome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TabPage FunnyPage;
        private System.Windows.Forms.Button funny_but;
        private System.Windows.Forms.TabPage account;
        private System.Windows.Forms.DataGridView dataAccountView;
        private System.Windows.Forms.TabPage tabconnect;
        private System.Windows.Forms.Button but_manual;
        private System.Windows.Forms.Button but_automatic;
        private System.Windows.Forms.Button dis_but;
        private System.Windows.Forms.CheckBox handtest;
        private System.Windows.Forms.CheckBox seeTEST;
        private System.Windows.Forms.TextBox testcon_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button con_but;
        private System.Windows.Forms.TabControl welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Camera;
    }
}