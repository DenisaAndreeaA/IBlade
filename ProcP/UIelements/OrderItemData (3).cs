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
            get
            {
                if (comboBox1.SelectedItem != null)
                { return comboBox1.SelectedItem.ToString(); }
                return null;
            }
            set { comboBox1.SelectedItem = value; }
        }
        public string typeItem
        {
            get
            {
                
                if (rbInbound.Checked) { return "Inbound"; }
                if (rbOutbound.Checked) { return "Outbound"; }
                return null;
            }

            set { }
        }
        public int quantityItems
        {
            get
            {
                if (numericUpDown1.Value != 0)
                { return Convert.ToInt32(numericUpDown1.Value); }
                return 0;
            }
            set { numericUpDown1.Value = value; }
        }

    }
}
