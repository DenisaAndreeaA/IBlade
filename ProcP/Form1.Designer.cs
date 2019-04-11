﻿namespace ProcP
{
	partial class iBlade
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseSpecificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSimulationDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWSchange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pbTimeLine = new System.Windows.Forms.PictureBox();
            this.btnStartSim = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveOrders = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMainSettings = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeLine)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelMainSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseSpecificationsToolStripMenuItem,
            this.orderSimulationDataToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // warehouseSpecificationsToolStripMenuItem
            // 
            this.warehouseSpecificationsToolStripMenuItem.Name = "warehouseSpecificationsToolStripMenuItem";
            this.warehouseSpecificationsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.warehouseSpecificationsToolStripMenuItem.Text = "Warehouse Specifications";
            this.warehouseSpecificationsToolStripMenuItem.Click += new System.EventHandler(this.warehouseSpecificationsToolStripMenuItem_Click);
            // 
            // orderSimulationDataToolStripMenuItem
            // 
            this.orderSimulationDataToolStripMenuItem.Name = "orderSimulationDataToolStripMenuItem";
            this.orderSimulationDataToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.orderSimulationDataToolStripMenuItem.Text = "Order Simulation Data";
            this.orderSimulationDataToolStripMenuItem.Click += new System.EventHandler(this.orderSimulationDataToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyDataToolStripMenuItem,
            this.comparisonToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // historyDataToolStripMenuItem
            // 
            this.historyDataToolStripMenuItem.Name = "historyDataToolStripMenuItem";
            this.historyDataToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.historyDataToolStripMenuItem.Text = "History data";
            // 
            // comparisonToolStripMenuItem
            // 
            this.comparisonToolStripMenuItem.Name = "comparisonToolStripMenuItem";
            this.comparisonToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.comparisonToolStripMenuItem.Text = "Comparison";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouse Specifications";
            // 
            // btnWSchange
            // 
            this.btnWSchange.BackColor = System.Drawing.Color.PowderBlue;
            this.btnWSchange.Location = new System.Drawing.Point(13, 53);
            this.btnWSchange.Name = "btnWSchange";
            this.btnWSchange.Size = new System.Drawing.Size(210, 45);
            this.btnWSchange.TabIndex = 6;
            this.btnWSchange.Text = "Change";
            this.btnWSchange.UseVisualStyleBackColor = false;
            this.btnWSchange.Click += new System.EventHandler(this.btnWSchange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Settings";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpload.Location = new System.Drawing.Point(125, 163);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 45);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.Location = new System.Drawing.Point(263, 86);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(907, 655);
            this.pbMain.TabIndex = 11;
            this.pbMain.TabStop = false;
            // 
            // pbTimeLine
            // 
            this.pbTimeLine.Location = new System.Drawing.Point(263, 34);
            this.pbTimeLine.Name = "pbTimeLine";
            this.pbTimeLine.Size = new System.Drawing.Size(907, 46);
            this.pbTimeLine.TabIndex = 12;
            this.pbTimeLine.TabStop = false;
            // 
            // btnStartSim
            // 
            this.btnStartSim.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStartSim.Location = new System.Drawing.Point(13, 349);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(214, 45);
            this.btnStartSim.TabIndex = 13;
            this.btnStartSim.Text = "START SIMULATION";
            this.btnStartSim.UseVisualStyleBackColor = false;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSet.Location = new System.Drawing.Point(13, 163);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(99, 45);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "Set Orders";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.btnSaveToFile);
            this.panelSettings.Controls.Add(this.btnCancel);
            this.panelSettings.Controls.Add(this.btnSaveOrders);
            this.panelSettings.Controls.Add(this.flowLayoutPanel1);
            this.panelSettings.Location = new System.Drawing.Point(262, 28);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(908, 713);
            this.panelSettings.TabIndex = 15;
            this.panelSettings.Visible = false;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(491, 665);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(173, 35);
            this.btnSaveToFile.TabIndex = 3;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 665);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveOrders
            // 
            this.btnSaveOrders.Location = new System.Drawing.Point(688, 664);
            this.btnSaveOrders.Name = "btnSaveOrders";
            this.btnSaveOrders.Size = new System.Drawing.Size(171, 36);
            this.btnSaveOrders.TabIndex = 1;
            this.btnSaveOrders.Text = "Save Orders";
            this.btnSaveOrders.UseVisualStyleBackColor = true;
            this.btnSaveOrders.Click += new System.EventHandler(this.btnSaveOrders_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 605);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 2);
            this.label4.TabIndex = 16;
            // 
            // panelMainSettings
            // 
            this.panelMainSettings.Controls.Add(this.comboBox1);
            this.panelMainSettings.Controls.Add(this.label6);
            this.panelMainSettings.Controls.Add(this.label5);
            this.panelMainSettings.Controls.Add(this.label4);
            this.panelMainSettings.Controls.Add(this.btnSet);
            this.panelMainSettings.Controls.Add(this.btnStartSim);
            this.panelMainSettings.Controls.Add(this.label3);
            this.panelMainSettings.Controls.Add(this.btnUpload);
            this.panelMainSettings.Controls.Add(this.label2);
            this.panelMainSettings.Controls.Add(this.btnWSchange);
            this.panelMainSettings.Controls.Add(this.label1);
            this.panelMainSettings.Location = new System.Drawing.Point(12, 28);
            this.panelMainSettings.Name = "panelMainSettings";
            this.panelMainSettings.Size = new System.Drawing.Size(242, 707);
            this.panelMainSettings.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Test data for first iteration:";
            // 
            // iBlade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelMainSettings);
            this.Controls.Add(this.pbTimeLine);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "iBlade";
            this.Text = "iBlade Warehouse Simulation";
            this.Load += new System.EventHandler(this.iBlade_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeLine)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelMainSettings.ResumeLayout(false);
            this.panelMainSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWSchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.PictureBox pbTimeLine;
        private System.Windows.Forms.Button btnStartSim;
        private System.Windows.Forms.ToolStripMenuItem warehouseSpecificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderSimulationDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparisonToolStripMenuItem;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveOrders;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMainSettings;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

