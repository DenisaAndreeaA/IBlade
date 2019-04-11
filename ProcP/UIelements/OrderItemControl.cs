using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP.UIelements
{
    public partial class OrderItemControl : UserControl
    {
        List<Product> products = new List<Product>();


        public OrderItemControl()
        {
            InitializeComponent();
            comboBox1.DataSource = ProductList.possibleProducts;
            comboBox1.DisplayMember = "FullName";
           
        }

        public Product chosenItem
        {
            get
            {
                return comboBox1.SelectedItem as Product;
            }
            set
            {
                comboBox1.SelectedItem = value;
                comboBox1.DisplayMember = "FullName";
            }
        }

        public int quantityOfItem
        {
            get { return Convert.ToInt32(numericUpDown1.Value); }
            set { numericUpDown1.Value = value; }
        }

    }
}
