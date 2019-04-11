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
    public partial class OrdersFormPopup : Form
    {
        List<Order> orders;
        List<AGV> agvs;

        public Warehouse wh; // stores the warehouse object from Form1.cs
        public PictureBox mainFormImage;

        public OrdersFormPopup(List<Order> ListOrders, List<AGV> ListAGVs, Warehouse w, PictureBox img)
        {
            InitializeComponent();
            orders = ListOrders;
            agvs = ListAGVs;

            wh = w;
            mainFormImage = img;

            foreach (Order o in orders)
            {               
                listBoxOrderId.Items.Add(o);              
            }
            listBoxOrderId.DisplayMember = "ID";

            foreach (AGV a in agvs)
            {
                listBoxAGV.Items.Add(a);               
            }
            listBoxAGV.DisplayMember = "ID";

            mainFormImage.Image = wh.DrawAreas();
        }

        private void listBoxOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxOrderItems.Items.Clear();
                foreach (OrderItem oi in (listBoxOrderId.SelectedItem as Order).GetListOrderItems())
                {
                    listBoxOrderItems.Items.Add("Product name: " + oi.productItem.Name + " , quantity: " + oi.Quantity);
                }
            }
            catch (NullReferenceException ne)
            { }
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Order selectedOrder = (listBoxOrderId.SelectedItem) as Order;
                AGV selectedAGV = (listBoxAGV.SelectedItem) as AGV;

                selectedAGV.AddOrder(selectedOrder);

                listBoxAGV.ClearSelected();
                listBoxOrderId.Items.RemoveAt(listBoxOrderId.SelectedIndex);
            }
            catch (Exception ex) { }
            
        }

        private void listBoxAGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxAGVOrders.Items.Clear();
                AGV selectedAGV = listBoxAGV.SelectedItem as AGV;
                foreach (Order o in selectedAGV.GetAGVOrders())
                {
                    listBoxAGVOrders.Items.Add(o);
                }
                listBoxAGVOrders.DisplayMember = "ID";
            }
            catch (NullReferenceException ne)
            { }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (listBoxAGVOrders.SelectedItem) as Order;
            AGV selectedAGV = listBoxAGV.SelectedItem as AGV;
            
            foreach (AGV agv in wh.AGVList)
            { 
                if(selectedAGV.ID == agv.ID)
                {
                    agv.RemoveOrder(selectedOrder);
                }
            }
            listBoxAGVOrders.Items.Remove(selectedOrder);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxOrderId.Items.Clear();
            foreach (Order o in orders)
            {
                //Console.WriteLine("Order to add to listbox" + o.ID);
                listBoxOrderId.Items.Add(o);
                listBoxOrderId.DisplayMember = "ID";
            }
        }

        
    }
}
