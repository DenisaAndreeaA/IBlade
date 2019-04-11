using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcP.UIelements;

namespace ProcP
{
    public partial class OrderControl : UserControl
    {
        Warehouse w;

        public OrderControl(Warehouse wh)
        {
            InitializeComponent();
            w = wh;
        }

        public DateTime StartTime
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }


     
        public string TypeItem
        {
            get
            {
                if (rbInbound.Checked) { return "Inbound"; }
                if (rbOutbound.Checked) { return "Outbound"; }
                return "";
            }

            set
            {
                if (value == "Inbound") rbInbound.Checked = true;
                else rbOutbound.Checked = true;
            }
        }

       public FlowLayoutPanel OrderItemFlowPanel
        {
            get
            {
                return flowLayoutPanel1;
            }
            set
            {
                flowLayoutPanel1 = value;
            }
        }


        public List<OrderItemControl> ItemControlList
        {
            get
            {
                return flowLayoutPanel1.Controls.OfType<OrderItemControl>().ToList();
                //return this.Controls.OfType<OrderItemControl>().ToList();
            }
            set
            {
                List<OrderItemControl> list = flowLayoutPanel1.Controls.OfType<OrderItemControl>().ToList();
                list = value;
            }
        }

       
        private void btnMoreItem_Click(object sender, EventArgs e)
        {
            OrderItemControl oi = new OrderItemControl();
            flowLayoutPanel1.Controls.Add(oi);
            this.ItemControlList.Add(oi);
            
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            rbInbound.Checked = false;
            rbOutbound.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            orderItemControl1.quantityOfItem = 0;
           
        }
    }
}
