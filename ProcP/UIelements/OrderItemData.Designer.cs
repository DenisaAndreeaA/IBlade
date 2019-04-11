namespace ProcP
{
    partial class OrderItemData
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rbInbound = new System.Windows.Forms.RadioButton();
            this.rbOutbound = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.numericUpDown1);
            this.gbOrder.Controls.Add(this.label4);
            this.gbOrder.Controls.Add(this.comboBox1);
            this.gbOrder.Controls.Add(this.label3);
            this.gbOrder.Controls.Add(this.label2);
            this.gbOrder.Controls.Add(this.panel1);
            this.gbOrder.Controls.Add(this.label1);
            this.gbOrder.Controls.Add(this.dateTimePicker1);
            this.gbOrder.Location = new System.Drawing.Point(10, 8);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(780, 165);
            this.gbOrder.TabIndex = 0;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 22);
            this.dateTimePicker1.TabIndex = 0;
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
            // rbInbound
            // 
            this.rbInbound.AutoSize = true;
            this.rbInbound.Location = new System.Drawing.Point(16, 8);
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
            this.rbOutbound.Location = new System.Drawing.Point(158, 8);
            this.rbOutbound.Name = "rbOutbound";
            this.rbOutbound.Size = new System.Drawing.Size(92, 21);
            this.rbOutbound.TabIndex = 3;
            this.rbOutbound.TabStop = true;
            this.rbOutbound.Text = "Outbound";
            this.rbOutbound.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbInbound);
            this.panel1.Controls.Add(this.rbOutbound);
            this.panel1.Location = new System.Drawing.Point(138, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 37);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(492, 112);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(114, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // OrderItemData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOrder);
            this.Name = "OrderItemData";
            this.Size = new System.Drawing.Size(800, 189);
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbInbound;
        private System.Windows.Forms.RadioButton rbOutbound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
