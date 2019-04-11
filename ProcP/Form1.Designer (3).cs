namespace ProcP
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseSpecificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSimulationDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWSchange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnStartSim = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.labelHorizontalLine = new System.Windows.Forms.Label();
            this.panelMainSettings = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.setSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AGVtimer = new System.Windows.Forms.Timer(this.components);
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageSimulation = new System.Windows.Forms.TabPage();
            this.TabPageOrderSettings = new System.Windows.Forms.TabPage();
            this.OrderContainerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderLIstButtonPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnExtraOrder = new System.Windows.Forms.Button();
            this.btnSaveOrders = new System.Windows.Forms.Button();
            this.TabPageStatistics = new System.Windows.Forms.TabPage();
            this.statsPage = new ProcP.UIelements.StatisticsPage();
            this.RandomTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.panelMainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.TabControlMain.SuspendLayout();
            this.TabPageSimulation.SuspendLayout();
            this.TabPageOrderSettings.SuspendLayout();
            this.OrderContainerFlowPanel.SuspendLayout();
            this.OrderLIstButtonPanel.SuspendLayout();
            this.TabPageStatistics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(12, 1, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(1282, 26);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseSpecificationsToolStripMenuItem,
            this.orderSimulationDataToolStripMenuItem,
            this.simulationViewToolStripMenuItem});
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
            // simulationViewToolStripMenuItem
            // 
            this.simulationViewToolStripMenuItem.Name = "simulationViewToolStripMenuItem";
            this.simulationViewToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.simulationViewToolStripMenuItem.Text = "Simulation View";
            this.simulationViewToolStripMenuItem.Click += new System.EventHandler(this.simulationViewToolStripMenuItem_Click);
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
            this.historyDataToolStripMenuItem.Click += new System.EventHandler(this.historyDataToolStripMenuItem_Click);
            // 
            // comparisonToolStripMenuItem
            // 
            this.comparisonToolStripMenuItem.Name = "comparisonToolStripMenuItem";
            this.comparisonToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.comparisonToolStripMenuItem.Text = "Comparison";
            this.comparisonToolStripMenuItem.Click += new System.EventHandler(this.comparisonToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Warehouse Specifications";
            // 
            // btnWSchange
            // 
            this.btnWSchange.BackColor = System.Drawing.Color.PowderBlue;
            this.btnWSchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWSchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnWSchange.Location = new System.Drawing.Point(14, 49);
            this.btnWSchange.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnWSchange.Name = "btnWSchange";
            this.btnWSchange.Size = new System.Drawing.Size(308, 42);
            this.btnWSchange.TabIndex = 6;
            this.btnWSchange.Text = "Set Specifications";
            this.btnWSchange.UseVisualStyleBackColor = false;
            this.btnWSchange.Click += new System.EventHandler(this.btnWSchange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Order Settings";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(192, 240);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(130, 42);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnStartSim
            // 
            this.btnStartSim.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStartSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnStartSim.Location = new System.Drawing.Point(16, 396);
            this.btnStartSim.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(306, 42);
            this.btnStartSim.TabIndex = 13;
            this.btnStartSim.Text = "START SIMULATION";
            this.btnStartSim.UseVisualStyleBackColor = false;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(16, 240);
            this.btnSet.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(130, 42);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "Set Orders";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // labelHorizontalLine
            // 
            this.labelHorizontalLine.BackColor = System.Drawing.Color.DarkTurquoise;
            this.labelHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHorizontalLine.Location = new System.Drawing.Point(16, 158);
            this.labelHorizontalLine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHorizontalLine.Name = "labelHorizontalLine";
            this.labelHorizontalLine.Size = new System.Drawing.Size(308, 1);
            this.labelHorizontalLine.TabIndex = 16;
            // 
            // panelMainSettings
            // 
            this.panelMainSettings.Controls.Add(this.button1);
            this.panelMainSettings.Controls.Add(this.label6);
            this.panelMainSettings.Controls.Add(this.setSpeed);
            this.panelMainSettings.Controls.Add(this.label5);
            this.panelMainSettings.Controls.Add(this.label4);
            this.panelMainSettings.Controls.Add(this.label3);
            this.panelMainSettings.Controls.Add(this.btnStartSim);
            this.panelMainSettings.Controls.Add(this.labelHorizontalLine);
            this.panelMainSettings.Controls.Add(this.btnSet);
            this.panelMainSettings.Controls.Add(this.btnUpload);
            this.panelMainSettings.Controls.Add(this.label2);
            this.panelMainSettings.Controls.Add(this.btnWSchange);
            this.panelMainSettings.Controls.Add(this.label1);
            this.panelMainSettings.Location = new System.Drawing.Point(9, 147);
            this.panelMainSettings.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panelMainSettings.Name = "panelMainSettings";
            this.panelMainSettings.Size = new System.Drawing.Size(352, 456);
            this.panelMainSettings.TabIndex = 17;
            this.panelMainSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainSettings_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Set the Speed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Speed AGVs:";
            // 
            // setSpeed
            // 
            this.setSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.setSpeed.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.setSpeed.Location = new System.Drawing.Point(116, 116);
            this.setSpeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.setSpeed.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.setSpeed.Name = "setSpeed";
            this.setSpeed.Size = new System.Drawing.Size(90, 19);
            this.setSpeed.TabIndex = 18;
            this.setSpeed.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(21, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 1);
            this.label5.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "3. Simulation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(155, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "or...";
            // 
            // AGVtimer
            // 
            this.AGVtimer.Interval = 25;
            this.AGVtimer.Tick += new System.EventHandler(this.AGVtimer_Tick);
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.SystemColors.Control;
            this.pbMain.Location = new System.Drawing.Point(37, 49);
            this.pbMain.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pbMain.Name = "pbMain";
            this.pbMain.Padding = new System.Windows.Forms.Padding(111, 0, 0, 0);
            this.pbMain.Size = new System.Drawing.Size(847, 649);
            this.pbMain.TabIndex = 11;
            this.pbMain.TabStop = false;
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDown);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseUp);
            // 
            // TabControlMain
            // 
            this.TabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControlMain.Controls.Add(this.TabPageSimulation);
            this.TabControlMain.Controls.Add(this.TabPageOrderSettings);
            this.TabControlMain.Controls.Add(this.TabPageStatistics);
            this.TabControlMain.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControlMain.Location = new System.Drawing.Point(367, 37);
            this.TabControlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(902, 754);
            this.TabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControlMain.TabIndex = 4;
            // 
            // TabPageSimulation
            // 
            this.TabPageSimulation.Controls.Add(this.pbMain);
            this.TabPageSimulation.Location = new System.Drawing.Point(4, 5);
            this.TabPageSimulation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageSimulation.Name = "TabPageSimulation";
            this.TabPageSimulation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageSimulation.Size = new System.Drawing.Size(894, 745);
            this.TabPageSimulation.TabIndex = 1;
            this.TabPageSimulation.UseVisualStyleBackColor = true;
            // 
            // TabPageOrderSettings
            // 
            this.TabPageOrderSettings.AutoScroll = true;
            this.TabPageOrderSettings.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageOrderSettings.Controls.Add(this.OrderContainerFlowPanel);
            this.TabPageOrderSettings.Location = new System.Drawing.Point(4, 5);
            this.TabPageOrderSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageOrderSettings.Name = "TabPageOrderSettings";
            this.TabPageOrderSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageOrderSettings.Size = new System.Drawing.Size(894, 745);
            this.TabPageOrderSettings.TabIndex = 0;
            // 
            // OrderContainerFlowPanel
            // 
            this.OrderContainerFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.OrderContainerFlowPanel.Controls.Add(this.OrderListPanel);
            this.OrderContainerFlowPanel.Controls.Add(this.OrderLIstButtonPanel);
            this.OrderContainerFlowPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.OrderContainerFlowPanel.Location = new System.Drawing.Point(4, 3);
            this.OrderContainerFlowPanel.Name = "OrderContainerFlowPanel";
            this.OrderContainerFlowPanel.Size = new System.Drawing.Size(883, 736);
            this.OrderContainerFlowPanel.TabIndex = 0;
            // 
            // OrderListPanel
            // 
            this.OrderListPanel.AllowDrop = true;
            this.OrderListPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderListPanel.AutoScroll = true;
            this.OrderListPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OrderListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrderListPanel.Location = new System.Drawing.Point(4, 3);
            this.OrderListPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrderListPanel.MaximumSize = new System.Drawing.Size(800, 650);
            this.OrderListPanel.Name = "OrderListPanel";
            this.OrderListPanel.Size = new System.Drawing.Size(800, 650);
            this.OrderListPanel.TabIndex = 4;
            this.OrderListPanel.WrapContents = false;
            // 
            // OrderLIstButtonPanel
            // 
            this.OrderLIstButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderLIstButtonPanel.Controls.Add(this.btnCancel);
            this.OrderLIstButtonPanel.Controls.Add(this.btnSaveToFile);
            this.OrderLIstButtonPanel.Controls.Add(this.btnExtraOrder);
            this.OrderLIstButtonPanel.Controls.Add(this.btnSaveOrders);
            this.OrderLIstButtonPanel.Location = new System.Drawing.Point(4, 659);
            this.OrderLIstButtonPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrderLIstButtonPanel.Name = "OrderLIstButtonPanel";
            this.OrderLIstButtonPanel.Size = new System.Drawing.Size(800, 51);
            this.OrderLIstButtonPanel.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(26, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSaveToFile.Location = new System.Drawing.Point(192, 7);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(152, 36);
            this.btnSaveToFile.TabIndex = 3;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnExtraOrder
            // 
            this.btnExtraOrder.BackColor = System.Drawing.Color.PowderBlue;
            this.btnExtraOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtraOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnExtraOrder.Location = new System.Drawing.Point(352, 6);
            this.btnExtraOrder.Name = "btnExtraOrder";
            this.btnExtraOrder.Size = new System.Drawing.Size(170, 36);
            this.btnExtraOrder.TabIndex = 1;
            this.btnExtraOrder.Text = "+ Extra Order";
            this.btnExtraOrder.UseVisualStyleBackColor = false;
            this.btnExtraOrder.Click += new System.EventHandler(this.btnExtraOrder_Click);
            // 
            // btnSaveOrders
            // 
            this.btnSaveOrders.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSaveOrders.Location = new System.Drawing.Point(532, 6);
            this.btnSaveOrders.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSaveOrders.Name = "btnSaveOrders";
            this.btnSaveOrders.Size = new System.Drawing.Size(242, 36);
            this.btnSaveOrders.TabIndex = 1;
            this.btnSaveOrders.Text = "Save Orders";
            this.btnSaveOrders.UseVisualStyleBackColor = false;
            this.btnSaveOrders.Click += new System.EventHandler(this.btnSaveOrders_Click);
            // 
            // TabPageStatistics
            // 
            this.TabPageStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageStatistics.Controls.Add(this.statsPage);
            this.TabPageStatistics.Location = new System.Drawing.Point(4, 5);
            this.TabPageStatistics.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageStatistics.Name = "TabPageStatistics";
            this.TabPageStatistics.Size = new System.Drawing.Size(894, 745);
            this.TabPageStatistics.TabIndex = 2;
            this.TabPageStatistics.Text = "TabPageStatistics";
            // 
            // statsPage
            // 
            this.statsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.statsPage.Location = new System.Drawing.Point(0, 3);
            this.statsPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.statsPage.Name = "statsPage";
            this.statsPage.Size = new System.Drawing.Size(892, 718);
            this.statsPage.TabIndex = 0;
            // 
            // RandomTimer
            // 
            this.RandomTimer.Interval = 1000;
            this.RandomTimer.Tick += new System.EventHandler(this.RandomTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 657);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 134);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legend";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(74, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Set Priority";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(74, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Move Line";
            // 
            // iBlade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 803);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMainSettings);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.TabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximumSize = new System.Drawing.Size(1300, 850);
            this.Name = "iBlade";
            this.Text = "iBlade Warehouse Simulation";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panelMainSettings.ResumeLayout(false);
            this.panelMainSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.TabControlMain.ResumeLayout(false);
            this.TabPageSimulation.ResumeLayout(false);
            this.TabPageOrderSettings.ResumeLayout(false);
            this.OrderContainerFlowPanel.ResumeLayout(false);
            this.OrderLIstButtonPanel.ResumeLayout(false);
            this.TabPageStatistics.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWSchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnStartSim;
        private System.Windows.Forms.ToolStripMenuItem warehouseSpecificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderSimulationDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparisonToolStripMenuItem;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveOrders;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label labelHorizontalLine;
        private System.Windows.Forms.Panel panelMainSettings;
        private System.Windows.Forms.Timer AGVtimer;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabPageOrderSettings;
        private System.Windows.Forms.TabPage TabPageSimulation;
        private System.Windows.Forms.FlowLayoutPanel OrderListPanel;
        private System.Windows.Forms.Panel OrderLIstButtonPanel;
        private System.Windows.Forms.TabPage TabPageStatistics;
        private System.Windows.Forms.FlowLayoutPanel OrderContainerFlowPanel;
        private System.Windows.Forms.Button btnExtraOrder;
        private System.Windows.Forms.ToolStripMenuItem simulationViewToolStripMenuItem;
        public System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Timer RandomTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private UIelements.StatisticsPage statsPage;
        private System.Windows.Forms.NumericUpDown setSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

