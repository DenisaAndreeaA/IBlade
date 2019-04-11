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
	public partial class ProductsSetup : Form
	{
		public Warehouse wh;
        public Rack thisRack;
        public PictureBox pbm;

		public ProductsSetup(Warehouse w, Rack r, PictureBox pbMain)
		{
			InitializeComponent();
			wh = w;
            thisRack = r;
            pbm = pbMain;
            CBpossibleProds.DataSource = ProductList.possibleProducts;
            CBpossibleProds.DisplayMember = "FullName";
            if (thisRack.RackStock.Count != 0)
                thisRack.RackStock.ForEach(x => lblCurrentProd.Text = x.productItem.FullName);
            else lblCurrentProd.Text = "This rack is empty.";
            if (thisRack.Available)
                checkBox1.Checked = true;
            else checkBox1.Checked = false;
		}

        private void btnFillRack_Click(object sender, EventArgs e)
        {
            try
            {
                OrderItem oi = new OrderItem(CBpossibleProds.SelectedItem as Product, 10, "Outbound");
                oi.Status = OIStatus.ONRACK;
                thisRack.RackStock.Add (oi);
                thisRack.DrawRack();
                wh.DrawAreas();
                this.Close();
                pbm.Invalidate();
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.ToString() + ", please choose a product from the list");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                thisRack.Available = false;
                thisRack.DrawRack();
                pbm.Invalidate();
            }
        }
    }
}
