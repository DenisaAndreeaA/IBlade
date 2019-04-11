namespace ProcP.UIelements
{
    partial class StatisticsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.btnSaveOverview = new System.Windows.Forms.Button();
            this.barChartOutIn = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.ordersInTimeChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.FlowPanelAGV = new System.Windows.Forms.FlowLayoutPanel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tabPageComparison = new System.Windows.Forms.TabPage();
            this.compBarChart = new LiveCharts.WinForms.CartesianChart();
            this.compTimeChart = new LiveCharts.WinForms.CartesianChart();
            this.compPieChartNew = new LiveCharts.WinForms.PieChart();
            this.compPieChartOld = new LiveCharts.WinForms.PieChart();
            this.btnUploadOverview = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageComparison.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOverview);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageComparison);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 637);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.btnSaveOverview);
            this.tabPageOverview.Controls.Add(this.barChartOutIn);
            this.tabPageOverview.Controls.Add(this.label2);
            this.tabPageOverview.Controls.Add(this.ordersInTimeChart);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 21);
            this.tabPageOverview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageOverview.Size = new System.Drawing.Size(880, 612);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // btnSaveOverview
            // 
            this.btnSaveOverview.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSaveOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSaveOverview.Location = new System.Drawing.Point(742, 565);
            this.btnSaveOverview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveOverview.Name = "btnSaveOverview";
            this.btnSaveOverview.Size = new System.Drawing.Size(122, 31);
            this.btnSaveOverview.TabIndex = 3;
            this.btnSaveOverview.Text = "Save overview";
            this.btnSaveOverview.UseVisualStyleBackColor = false;
            this.btnSaveOverview.Click += new System.EventHandler(this.btnSaveOverview_Click);
            // 
            // barChartOutIn
            // 
            this.barChartOutIn.Location = new System.Drawing.Point(275, 71);
            this.barChartOutIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barChartOutIn.Name = "barChartOutIn";
            this.barChartOutIn.Size = new System.Drawing.Size(349, 208);
            this.barChartOutIn.TabIndex = 2;
            this.barChartOutIn.Text = "cartesianChart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Warehouse utilization";
            // 
            // ordersInTimeChart
            // 
            this.ordersInTimeChart.Location = new System.Drawing.Point(70, 308);
            this.ordersInTimeChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ordersInTimeChart.Name = "ordersInTimeChart";
            this.ordersInTimeChart.Size = new System.Drawing.Size(719, 236);
            this.ordersInTimeChart.TabIndex = 0;
            this.ordersInTimeChart.Text = "cartesianChart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.FlowPanelAGV);
            this.tabPage2.Controls.Add(this.pieChart1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(880, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AGV performance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "AGV order handling rate:";
            // 
            // FlowPanelAGV
            // 
            this.FlowPanelAGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FlowPanelAGV.Location = new System.Drawing.Point(44, 307);
            this.FlowPanelAGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FlowPanelAGV.Name = "FlowPanelAGV";
            this.FlowPanelAGV.Size = new System.Drawing.Size(806, 283);
            this.FlowPanelAGV.TabIndex = 3;
            // 
            // pieChart1
            // 
            this.pieChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pieChart1.Location = new System.Drawing.Point(48, 64);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(803, 219);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "pieChart1";
            // 
            // tabPageComparison
            // 
            this.tabPageComparison.Controls.Add(this.compBarChart);
            this.tabPageComparison.Controls.Add(this.compTimeChart);
            this.tabPageComparison.Controls.Add(this.compPieChartNew);
            this.tabPageComparison.Controls.Add(this.compPieChartOld);
            this.tabPageComparison.Controls.Add(this.btnUploadOverview);
            this.tabPageComparison.Controls.Add(this.label4);
            this.tabPageComparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabPageComparison.Location = new System.Drawing.Point(4, 21);
            this.tabPageComparison.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageComparison.Name = "tabPageComparison";
            this.tabPageComparison.Size = new System.Drawing.Size(880, 612);
            this.tabPageComparison.TabIndex = 2;
            this.tabPageComparison.Text = "Comparison";
            this.tabPageComparison.UseVisualStyleBackColor = true;
            // 
            // compBarChart
            // 
            this.compBarChart.Location = new System.Drawing.Point(71, 100);
            this.compBarChart.Name = "compBarChart";
            this.compBarChart.Size = new System.Drawing.Size(286, 169);
            this.compBarChart.TabIndex = 5;
            this.compBarChart.Text = "cartesianChart4";
            // 
            // compTimeChart
            // 
            this.compTimeChart.Location = new System.Drawing.Point(59, 334);
            this.compTimeChart.Name = "compTimeChart";
            this.compTimeChart.Size = new System.Drawing.Size(758, 241);
            this.compTimeChart.TabIndex = 4;
            this.compTimeChart.Text = "cartesianChart3";
            // 
            // compPieChartNew
            // 
            this.compPieChartNew.Location = new System.Drawing.Point(626, 106);
            this.compPieChartNew.Name = "compPieChartNew";
            this.compPieChartNew.Size = new System.Drawing.Size(191, 163);
            this.compPieChartNew.TabIndex = 3;
            this.compPieChartNew.Text = "pieChart3";
            // 
            // compPieChartOld
            // 
            this.compPieChartOld.Location = new System.Drawing.Point(404, 106);
            this.compPieChartOld.Name = "compPieChartOld";
            this.compPieChartOld.Size = new System.Drawing.Size(173, 164);
            this.compPieChartOld.TabIndex = 2;
            this.compPieChartOld.Text = "pieChart2";
            // 
            // btnUploadOverview
            // 
            this.btnUploadOverview.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUploadOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUploadOverview.Location = new System.Drawing.Point(258, 45);
            this.btnUploadOverview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUploadOverview.Name = "btnUploadOverview";
            this.btnUploadOverview.Size = new System.Drawing.Size(338, 29);
            this.btnUploadOverview.TabIndex = 1;
            this.btnUploadOverview.Text = "Upload an overview";
            this.btnUploadOverview.UseVisualStyleBackColor = false;
            this.btnUploadOverview.Click += new System.EventHandler(this.btnUploadOverview_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(232, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Compare the results to a previous one:";
            // 
            // StatisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "StatisticsPage";
            this.Size = new System.Drawing.Size(889, 640);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageOverview.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageComparison.ResumeLayout(false);
            this.tabPageComparison.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private LiveCharts.WinForms.CartesianChart ordersInTimeChart;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart barChartOutIn;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelAGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageComparison;
        private System.Windows.Forms.Button btnSaveOverview;
        private System.Windows.Forms.Button btnUploadOverview;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.CartesianChart compBarChart;
        private LiveCharts.WinForms.CartesianChart compTimeChart;
        private LiveCharts.WinForms.PieChart compPieChartNew;
        private LiveCharts.WinForms.PieChart compPieChartOld;
    }
}
