namespace ProcP.UIelements
{
    partial class OrdersFormPopup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOrderItems = new System.Windows.Forms.ListBox();
            this.listBoxOrderId = new System.Windows.Forms.ListBox();
            this.listBoxAGV = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxAGVOrders = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order number";
            // 
            // listBoxOrderItems
            // 
            this.listBoxOrderItems.FormattingEnabled = true;
            this.listBoxOrderItems.ItemHeight = 16;
            this.listBoxOrderItems.Location = new System.Drawing.Point(150, 38);
            this.listBoxOrderItems.Name = "listBoxOrderItems";
            this.listBoxOrderItems.Size = new System.Drawing.Size(442, 308);
            this.listBoxOrderItems.TabIndex = 5;
            // 
            // listBoxOrderId
            // 
            this.listBoxOrderId.FormattingEnabled = true;
            this.listBoxOrderId.ItemHeight = 16;
            this.listBoxOrderId.Location = new System.Drawing.Point(23, 38);
            this.listBoxOrderId.Name = "listBoxOrderId";
            this.listBoxOrderId.Size = new System.Drawing.Size(121, 308);
            this.listBoxOrderId.TabIndex = 4;
            this.listBoxOrderId.SelectedIndexChanged += new System.EventHandler(this.listBoxOrderId_SelectedIndexChanged);
            // 
            // listBoxAGV
            // 
            this.listBoxAGV.FormattingEnabled = true;
            this.listBoxAGV.ItemHeight = 16;
            this.listBoxAGV.Location = new System.Drawing.Point(620, 38);
            this.listBoxAGV.Name = "listBoxAGV";
            this.listBoxAGV.Size = new System.Drawing.Size(156, 308);
            this.listBoxAGV.TabIndex = 9;
            this.listBoxAGV.SelectedIndexChanged += new System.EventHandler(this.listBoxAGV_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Available AGVs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Assign Order To AGV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(452, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "Remove Order From AGV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxAGVOrders
            // 
            this.listBoxAGVOrders.FormattingEnabled = true;
            this.listBoxAGVOrders.ItemHeight = 16;
            this.listBoxAGVOrders.Location = new System.Drawing.Point(782, 38);
            this.listBoxAGVOrders.Name = "listBoxAGVOrders";
            this.listBoxAGVOrders.Size = new System.Drawing.Size(171, 308);
            this.listBoxAGVOrders.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "AGV Orders";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(930, 45);
            this.button4.TabIndex = 16;
            this.button4.Text = "Refresh Orders List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // OrdersFormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 487);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxAGVOrders);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxAGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOrderItems);
            this.Controls.Add(this.listBoxOrderId);
            this.Name = "OrdersFormPopup";
            this.Text = "Order assignment form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOrderItems;
        private System.Windows.Forms.ListBox listBoxOrderId;
        private System.Windows.Forms.ListBox listBoxAGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxAGVOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
    }
}