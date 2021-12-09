
namespace reapp_altium
{
    partial class Grap
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grap_power = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_StartGrap = new System.Windows.Forms.Button();
            this.btn_StopGrap = new System.Windows.Forms.Button();
            this.timer_power = new System.Windows.Forms.Timer(this.components);
            this.dataGridView_力 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.西家さんToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全データ削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laB_load = new System.Windows.Forms.Label();
            this.laB_maxLoad = new System.Windows.Forms.Label();
            this.laB_distance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_print1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grap_power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_力)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grap_power
            // 
            chartArea1.Name = "ChartArea1";
            this.Grap_power.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grap_power.Legends.Add(legend1);
            this.Grap_power.Location = new System.Drawing.Point(12, 124);
            this.Grap_power.Name = "Grap_power";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "timerCount";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "timerEnible";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "point";
            this.Grap_power.Series.Add(series1);
            this.Grap_power.Series.Add(series2);
            this.Grap_power.Series.Add(series3);
            this.Grap_power.Size = new System.Drawing.Size(685, 612);
            this.Grap_power.TabIndex = 0;
            this.Grap_power.Text = "chart1";
            // 
            // btn_StartGrap
            // 
            this.btn_StartGrap.Location = new System.Drawing.Point(766, 35);
            this.btn_StartGrap.Name = "btn_StartGrap";
            this.btn_StartGrap.Size = new System.Drawing.Size(91, 26);
            this.btn_StartGrap.TabIndex = 1;
            this.btn_StartGrap.Text = "Start";
            this.btn_StartGrap.UseVisualStyleBackColor = true;
            this.btn_StartGrap.Click += new System.EventHandler(this.btn_StartGrap_Click);
            // 
            // btn_StopGrap
            // 
            this.btn_StopGrap.Location = new System.Drawing.Point(888, 35);
            this.btn_StopGrap.Name = "btn_StopGrap";
            this.btn_StopGrap.Size = new System.Drawing.Size(91, 26);
            this.btn_StopGrap.TabIndex = 2;
            this.btn_StopGrap.Text = "Stop";
            this.btn_StopGrap.UseVisualStyleBackColor = true;
            this.btn_StopGrap.Click += new System.EventHandler(this.btn_StopGrap_Click);
            // 
            // timer_power
            // 
            this.timer_power.Tick += new System.EventHandler(this.timer_power_Tick);
            // 
            // dataGridView_力
            // 
            this.dataGridView_力.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_力.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_力.Location = new System.Drawing.Point(719, 124);
            this.dataGridView_力.Name = "dataGridView_力";
            this.dataGridView_力.RowHeadersWidth = 100;
            this.dataGridView_力.RowTemplate.Height = 21;
            this.dataGridView_力.Size = new System.Drawing.Size(415, 533);
            this.dataGridView_力.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.西家さんToolStripMenuItem,
            this.削除ToolStripMenuItem,
            this.全データ削除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
            // 
            // 西家さんToolStripMenuItem
            // 
            this.西家さんToolStripMenuItem.Name = "西家さんToolStripMenuItem";
            this.西家さんToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.西家さんToolStripMenuItem.Text = "再計算";
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            this.削除ToolStripMenuItem.Click += new System.EventHandler(this.削除ToolStripMenuItem_Click);
            // 
            // 全データ削除ToolStripMenuItem
            // 
            this.全データ削除ToolStripMenuItem.Name = "全データ削除ToolStripMenuItem";
            this.全データ削除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.全データ削除ToolStripMenuItem.Text = "全データ削除";
            this.全データ削除ToolStripMenuItem.Click += new System.EventHandler(this.全データ削除ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.laB_load, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.laB_maxLoad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.laB_distance, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.38462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.61538F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 104);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(211, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Force(kN)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(454, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "距離(mm)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laB_load
            // 
            this.laB_load.BackColor = System.Drawing.Color.GreenYellow;
            this.laB_load.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.laB_load.Location = new System.Drawing.Point(3, 42);
            this.laB_load.Name = "laB_load";
            this.laB_load.Size = new System.Drawing.Size(202, 62);
            this.laB_load.TabIndex = 3;
            this.laB_load.Text = "0.00";
            this.laB_load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laB_maxLoad
            // 
            this.laB_maxLoad.BackColor = System.Drawing.Color.GreenYellow;
            this.laB_maxLoad.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.laB_maxLoad.Location = new System.Drawing.Point(211, 42);
            this.laB_maxLoad.Name = "laB_maxLoad";
            this.laB_maxLoad.Size = new System.Drawing.Size(237, 62);
            this.laB_maxLoad.TabIndex = 4;
            this.laB_maxLoad.Text = "0.00";
            this.laB_maxLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laB_distance
            // 
            this.laB_distance.BackColor = System.Drawing.Color.GreenYellow;
            this.laB_distance.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.laB_distance.Location = new System.Drawing.Point(454, 42);
            this.laB_distance.Name = "laB_distance";
            this.laB_distance.Size = new System.Drawing.Size(227, 62);
            this.laB_distance.TabIndex = 5;
            this.laB_distance.Text = "0.00";
            this.laB_distance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "荷重(kN)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print1
            // 
            this.btn_print1.Location = new System.Drawing.Point(766, 80);
            this.btn_print1.Name = "btn_print1";
            this.btn_print1.Size = new System.Drawing.Size(91, 25);
            this.btn_print1.TabIndex = 14;
            this.btn_print1.Text = "Print";
            this.btn_print1.UseVisualStyleBackColor = true;
            this.btn_print1.Click += new System.EventHandler(this.btn_print1_Click);
            // 
            // Grap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 748);
            this.Controls.Add(this.btn_print1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView_力);
            this.Controls.Add(this.btn_StopGrap);
            this.Controls.Add(this.btn_StartGrap);
            this.Controls.Add(this.Grap_power);
            this.Name = "Grap";
            this.Text = "Grap";
            this.Load += new System.EventHandler(this.Grap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grap_power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_力)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_StartGrap;
        private System.Windows.Forms.Button btn_StopGrap;
        private System.Windows.Forms.Timer timer_power;
        private System.Windows.Forms.DataGridView dataGridView_力;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 西家さんToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全データ削除ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laB_load;
        private System.Windows.Forms.Label laB_maxLoad;
        private System.Windows.Forms.Label laB_distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print1;
        public System.Windows.Forms.DataVisualization.Charting.Chart Grap_power;
    }
}