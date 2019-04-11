using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP
{
    public partial class OrderItemData : UserControl
    {
        public OrderItemData()
        {
            InitializeComponent();
        }

        public DateTime StartTime
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

       /* public Product chosenItem
        {
            get { return comboBox1.SelectedValue as Product; }
            set { comboBox1.SelectedValue = value; }
        }
        */
        public string chosenItem
        {
            get { return comboBox1.SelectedText; }
            set { comboBox1.SelectedText = value; }
        }
        public string typeItem
        {
            get
            {
                if (rbInbound.Checked) { return "Inbound"; }
                if (rbOutbound.Checked) { return "Outbound"; }
                return "";
            }

            set { }
        }
        public int quantityItems
        {
            get { return Convert.ToInt32(numericUpDown1.Value);}
            set { numericUpDown1.Value = value; }
        }
    }
}
