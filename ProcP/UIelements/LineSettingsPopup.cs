using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP.UIelements
{
    public partial class LineSettingsPopup : Form
    {
        Line thisLine;
        public LineSettingsPopup(Line l)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(ProductType));
            thisLine = l;
            lblPrio.Text = thisLine.PriorityProduct.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProductType type;
                Enum.TryParse<ProductType>(comboBox1.SelectedValue.ToString(), out type);
                thisLine.PriorityProduct = type;
                this.Close();
            }
            catch (NullReferenceException ex) { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                thisLine.Available = false;
            }
        }
    }
}
