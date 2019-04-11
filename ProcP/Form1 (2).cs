using ProcP.UIelements;
using ProcP.WHobjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProcP
{
	public partial class iBlade : Form
	{
        private Warehouse wh;
        public static Bitmap DrawArea;
        private Line lineObj = new Line();
        public List<OrderItemData> ListOfOrdersForms; //List of OrderItemData FORMS

        private List<Order> ListOrders= new List<Order>(); //List of saved orders

		public iBlade()
		{
			InitializeComponent();
           // this.WindowState = FormWindowState.Maximized;  //the window starts maximized
        }


        /// <summary>
        /// Starts the simulation by creating a new Warehouse object and ...
        /// </summary>
        private void startSimulation()
        {
            wh = new Warehouse();
            this.pbMain.BackColor = Color.LightGray;
        }


        /// <summary>
        /// This method is called when the "Stop Simulation" btn fires an event in the SimulationControlPanel.
        /// </summary>
        private void OnStopSimulation(UserControl uc)
        {
            uc.Visible = false;
            AGVtimer.Enabled = false;
            this.pbMain.BackColor = Color.White;
        }


        /// <summary>
        /// Opens a small window to set the warehouse specifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWSchange_Click(object sender, EventArgs e)
        {
            var form = new WSpopup();
            form.Show(this);
        }


        /// <summary>
        /// Opens a File Explorer dialog box to upload .csv file with predefined order settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma-separated files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    // ...
                }
            }
        }


        /// <summary>
        /// Opens the order settings panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            pbMain.Visible = false;
            pbTimeLine.Visible = false;
            panelSettings.Visible = true;
            

            ListOfOrdersForms = new List<OrderItemData>();
           
            for (int i = 0; i < 10; i++)
            {
                OrderItemData oid = new OrderItemData();
                flowLayoutPanel1.Controls.Add(oid);
                ListOfOrdersForms.Add(oid);
            }
            

        }


        /// <summary>
        /// Calls the method that starts the simulation, changes the visible controls 
        /// on the left panel to controls relevant to the running simulation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartSim_Click(object sender, EventArgs e)
        {
            DrawArea = new Bitmap(pbMain.Size.Width, pbMain.Size.Height);
            startSimulation();

            SimulationControlPanel duringSimPanel = new SimulationControlPanel();
            this.Controls.Add(duringSimPanel);
            duringSimPanel.Location = new Point(10, 34);
            duringSimPanel.BringToFront();

            duringSimPanel.OnStopSim += (s, ec) => OnStopSimulation(duringSimPanel);

            PictureBox pictureOutbound = new PictureBox
            {
                Name = "pictureOutbound",
                Location = new Point(130, 550),
                Image = Properties.Resources.bound,
                SizeMode = PictureBoxSizeMode.CenterImage
            };
            pbMain.Controls.Add(pictureOutbound);


            wh.AGVList.Add(new AGV(pbMain.Size.Height, pbMain.Size.Width)); // adding agv with the start position
            wh.LinesList.Add(new Line() { });
            wh.LinesList.Add(new Line() { });
            Rack A10 = new Rack(new Point(374, 267));
            Rack A9 = new Rack(new Point(344, 267));
            Rack A8 = new Rack(new Point(314, 267));
            Rack A7 = new Rack(new Point(284, 267));
            Rack A6 = new Rack(new Point(254, 267));
            Rack A5 = new Rack(new Point(224, 267));
            Rack A4 = new Rack(new Point(194, 267));
            Rack A3 = new Rack(new Point(164, 267));
            Rack A2 = new Rack(new Point(134, 267));
            Rack A1 = new Rack(new Point(104, 267));
            wh.LinesList[0].RackList.Add(A1);   //Adding all racks to the first line
            wh.LinesList[0].RackList.Add(A2);
            wh.LinesList[0].RackList.Add(A3);
            wh.LinesList[0].RackList.Add(A4);
            wh.LinesList[0].RackList.Add(A5);
            wh.LinesList[0].RackList.Add(A6);
            wh.LinesList[0].RackList.Add(A7);
            wh.LinesList[0].RackList.Add(A8);
            wh.LinesList[0].RackList.Add(A9);
            wh.LinesList[0].RackList.Add(A10);
            Rack B10 = new Rack(new Point(772, 267));
            Rack B9 = new Rack(new Point(742, 267));
            Rack B8 = new Rack(new Point(712, 267));
            Rack B7 = new Rack(new Point(682, 267));
            Rack B6 = new Rack(new Point(652, 267));
            Rack B5 = new Rack(new Point(622, 267));
            Rack B4 = new Rack(new Point(592, 267));
            Rack B3 = new Rack(new Point(562, 267));
            Rack B2 = new Rack(new Point(532, 267));
            Rack B1 = new Rack(new Point(502, 267));
            wh.LinesList[1].RackList.Add(B1);   //Adding all racks to the second line
            wh.LinesList[1].RackList.Add(B2);
            wh.LinesList[1].RackList.Add(B3);
            wh.LinesList[1].RackList.Add(B4);
            wh.LinesList[1].RackList.Add(B5);
            wh.LinesList[1].RackList.Add(B6);
            wh.LinesList[1].RackList.Add(B7);
            wh.LinesList[1].RackList.Add(B8);
            wh.LinesList[1].RackList.Add(B9);
            wh.LinesList[1].RackList.Add(B10);
            wh.AGVList[0].LoadImage();

            //ShortestPathAsync(104,267);
            //ShortestPathAsync(300, 400);
            AGVtimer.Enabled = true;

            try
            {
                if (comboBox1.SelectedItem.ToString() == "chair")
                {
                    ShortestPathAsync(502, 267);
                    ShortestPathAsync(750, 520);
                }
                else if (comboBox1.SelectedItem.ToString() == "sofa")
                {
                    ShortestPathAsync(314, 267);
                    ShortestPathAsync(665, 550);
                    // wh.AGVList[0].changeDirection("right");
                    // timer1.Enabled = true;

                }
                else if (comboBox1.SelectedItem.ToString() == "table")
                {
                    ShortestPathAsync(622, 267);
                    ShortestPathAsync(750, 520);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an item.");
            }

            PictureBox pictureInbound = new PictureBox
            {
                Name = "pictureOutbound",
                Location = new Point(700, 550),
                Image = Properties.Resources.bound,
                SizeMode = PictureBoxSizeMode.CenterImage
            };
            pbMain.Controls.Add(pictureInbound);


            pictureInbound.Paint += new PaintEventHandler((senderi, ei) =>
            {
                ei.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                string text = "INBOUND";

                SizeF textSize = ei.Graphics.MeasureString(text, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (pictureInbound.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (pictureInbound.Height / 2) - (textSize.Height / 2);

                ei.Graphics.DrawString(text, Font, Brushes.Black, locationToDraw);
            });

            pictureInbound.Paint += new PaintEventHandler((senderi, ei) =>
            {
                ei.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                string text = "OUTBOUND";

                SizeF textSize = ei.Graphics.MeasureString(text, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (pictureInbound.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (pictureInbound.Height / 2) - (textSize.Height / 2);

                ei.Graphics.DrawString(text, Font, Brushes.Black, locationToDraw);
            });

            pictureOutbound.Paint += new PaintEventHandler((sendero, eo) =>
            {
                eo.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                string text = "INBOUND";

                SizeF textSize = eo.Graphics.MeasureString(text, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (pictureInbound.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (pictureInbound.Height / 2) - (textSize.Height / 2);

                eo.Graphics.DrawString(text, Font, Brushes.Black, locationToDraw);
            });
        }





        /// <summary>
        /// Hides order settings panel without order creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = false;
            pbMain.Visible = true;
            pbTimeLine.Visible = true;
        }


        /// <summary>
        /// Hides the order settings panel, creates orders from given data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveOrders_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = false;
            pbMain.Visible = true;
            pbTimeLine.Visible = true;
            
            
            foreach (var od in ListOfOrdersForms)
            {
                List<OrderItem> orderItems = new List<OrderItem>();
                foreach (OrderItem oi in orderItems)
                {
                    OrderItem item1 = new OrderItem(od.chosenItem.ToString(), od.quantityItems);
                    
                }
                Order order = new Order(od.typeItem, od.StartTime, orderItems);
                ListOrders.Add(order);

            }
            

        }


        #region MenuItem definitions

        private void warehouseSpecificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new WSpopup();
            form.Show(this);
        }

        private void orderSimulationDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbMain.Visible = false;
            pbTimeLine.Visible = false;
            panelSettings.Visible = true;
        }

        #endregion
        // the timer checks the direction of the agv and can rotate it
        private void AGVtimer_Tick(object sender, EventArgs e)
        {
            //wh.AGVList[0].changeDirection("none");
            //wh.AGVList[0].timerDraw(AGVtimer);
            List<Point> PointList = new List<Point>();
            PointList = wh.AGVList[0].PointList;
            if (PointList.Count != 0)
            {
                pbMain.Image = wh.AGVList[0].DrawPoints(PointList[0].X, PointList[0].Y, wh.AGVList[0].rotateAngle);
                if (PointList.Count > 1)
                {
                    if (PointList[0].X < PointList[1].X && PointList[0].Y < PointList[1].Y) wh.AGVList[0].rotateAngle = 45;
                    else if (PointList[0].X == PointList[1].X && PointList[0].Y < PointList[1].Y) wh.AGVList[0].rotateAngle = 90;
                    else if (PointList[0].X == PointList[1].X && PointList[0].Y > PointList[1].Y) wh.AGVList[0].rotateAngle = -90;
                    else if (PointList[0].X > PointList[1].X && PointList[0].Y > PointList[1].Y) wh.AGVList[0].rotateAngle = -135;
                    else if (PointList[0].X < PointList[1].X && PointList[0].Y < PointList[1].Y) wh.AGVList[0].rotateAngle = -45;
                    else if (PointList[0].X < PointList[1].X && PointList[0].Y > PointList[1].Y) wh.AGVList[0].rotateAngle = -45;
                    else if (PointList[0].X > PointList[1].X && PointList[0].Y < PointList[1].Y) wh.AGVList[0].rotateAngle = 135;
                    else if (PointList[0].X < PointList[1].X && PointList[0].Y == PointList[1].Y) wh.AGVList[0].rotateAngle = 0;
                    else if (PointList[0].X > PointList[1].X && PointList[0].Y == PointList[1].Y) wh.AGVList[0].rotateAngle = 180;
                }
                PointList.RemoveAt(0);
            }


            //pbMain.Image = wh.AGVList[0].DrawAGV(0);
            pbMain.Image = wh.LinesList[0].DrawLine(100,200);
            pbMain.Image = wh.LinesList[0].DrawLine(500, 200);

        }

        // this method uses the PathCalculator class to calculate the shortest path between 2 points and saves the path into a list
        // the put that list in the agv object
        private async void ShortestPathAsync(int x, int y)
        {
            while (wh.AGVList[0].PointList.Count != 0)
            {
                await Task.Delay(3000);
            }
            Point point1 = new Point(wh.AGVList[0].PositionX, wh.AGVList[0].PositionY);
            Point point2 = new Point(x, y);
            PathCalculator path = new PathCalculator(point1,point2);
            path.CalculatePath();
            wh.AGVList[0].PointList = path.GetPointList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            wh.AGVList[0].timerDraw(timer1);
        }
    }
}
