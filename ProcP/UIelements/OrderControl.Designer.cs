namespace ProcP
{
    partial class OrderControl
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
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnMoreItem = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderItemControl1 = new ProcP.UIelements.OrderItemControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbInbound = new System.Windows.Forms.RadioButton();
            this.rbOutbound = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbOrder.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.btnRemoveOrder);
            this.gbOrder.Controls.Add(this.btnMoreItem);
            this.gbOrder.Controls.Add(this.flowLayoutPanel1);
            this.gbOrder.Controls.Add(this.label2);
            this.gbOrder.Controls.Add(this.panel1);
            this.gbOrder.Controls.Add(this.label1);
            this.gbOrder.Controls.Add(this.dateTimePicker1);
            this.gbOrder.Location = new System.Drawing.Point(11, 7);
            this.gbOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOrder.Size = new System.Drawing.Size(975, 299);
            this.gbOrder.TabIndex = 0;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order";
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemoveOrder.Location = new System.Drawing.Point(819, 25);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(150, 39);
            this.btnRemoveOrder.TabIndex = 9;
            this.btnRemoveOrder.Text = "Remove Order";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnMoreItem
            // 
            this.btnMoreItem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMoreItem.Location = new System.Drawing.Point(819, 247);
            this.btnMoreItem.Name = "btnMoreItem";
            this.btnMoreItem.Size = new System.Drawing.Size(150, 36);
            this.btnMoreItem.TabIndex = 8;
            this.btnMoreItem.Text = "More items...";
            this.btnMoreItem.UseVisualStyleBackColor = false;
            this.btnMoreItem.Click += new System.EventHandler(this.btnMoreItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.orderItemControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 206);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // orderItemControl1
            // 
            this.orderItemControl1.Location = new System.Drawing.Point(3, 3);
            this.orderItemControl1.Name = "orderItemControl1";
            this.orderItemControl1.quantityOfItem = 0;
            this.orderItemControl1.Size = new System.Drawing.Size(727, 79);
            this.orderItemControl1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start time:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbInbound);
            this.panel1.Controls.Add(this.rbOutbound);
            this.panel1.Location = new System.Drawing.Point(139, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 37);
            this.panel1.TabIndex = 4;
            // 
            // rbInbound
            // 
            this.rbInbound.AutoSize = true;
            this.rbInbound.Location = new System.Drawing.Point(16, 7);
            this.rbInbound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbInbound.Name = "rbInbound";
            this.rbInbound.Size = new System.Drawing.Size(80, 21);
            this.rbInbound.TabIndex = 2;
            this.rbInbound.TabStop = true;
            this.rbInbound.Text = "Inbound";
            this.rbInbound.UseVisualStyleBackColor = true;
            // 
            // rbOutbound
            // 
            this.rbOutbound.AutoSize = true;
            this.rbOutbound.Location = new System.Drawing.Point(157, 7);
            this.rbOutbound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOutbound.Name = "rbOutbound";
            this.rbOutbound.Size = new System.Drawing.Size(92, 21);
            this.rbOutbound.TabIndex = 3;
            this.rbOutbound.TabStop = true;
            this.rbOutbound.Text = "Outbound";
            this.rbOutbound.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(584, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(990, 323);
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbInbound;
        private System.Windows.Forms.RadioButton rbOutbound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMoreItem;
        private UIelements.OrderItemControl orderItemControl1;
        private System.Windows.Forms.Button btnRemoveOrder;
    }
}
