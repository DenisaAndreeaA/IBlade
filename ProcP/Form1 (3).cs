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

        public static CsvHandler csvh;
        public static Warehouse wh;
        public static Bitmap DrawArea;
        public List<OrderControl> ListOfOrdersForms = new List<OrderControl>(); //List of OrderControls FORMS		
        public int counter = 0;
        public static Map map;
        public static bool Status = false;
        Random rnd;
        private bool busy = false;
        int countBusy=0;
        int countClicks = 0;
        private Line thisLine;


        


        public iBlade()
		{
			InitializeComponent();
			wh = new Warehouse(pbMain);
			DrawArea = new Bitmap(pbMain.Size.Width, pbMain.Size.Height);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);          
            map = new Map();
            csvh = new CsvHandler(wh);
            rnd = new Random();

            // this.WindowState = FormWindowState.Maximized;  //the window starts maximized


        }

        

        #region MenuItem definitions

        private void warehouseSpecificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new WSpopup(wh, pbMain);
            form.Show(this);
        }

        private void orderSimulationDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlMain.SelectedTab = TabPageOrderSettings;
        }

        private void simulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlMain.SelectedTab = TabPageStatistics;
            statsPage.statsTabControl.SelectTab("tabPageOverview");
        }

        private void comparisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlMain.SelectedTab = TabPageStatistics;
            statsPage.statsTabControl.SelectTab("tabPageComparison");
        }

        private void simulationViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlMain.SelectedTab = TabPageSimulation;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UserManual(wh, pbMain);
            form.Show(this);
        }
        #endregion

        /// <summary>
        /// This method is called when the "Stop Simulation" btn fires an event in the SimulationControlPanel.
        /// </summary>
        private void OnStopSimulation()
        {
            btnStartSim.Text = "START SIMULATION";
            btnStartSim.BackColor = Color.LightSeaGreen;
            AGVtimer.Enabled = false;           
            statsPage.CreateCharts(wh);
            TabControlMain.SelectedTab = TabPageStatistics;
            statsPage.statsTabControl.SelectTab("tabPageOverview");
            
        }


        /// <summary>
        /// Opens a small window to set the warehouse specifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWSchange_Click(object sender, EventArgs e)
        {
			pbMain.Image = null;
			var form = new WSpopup(wh, pbMain);
            form.Show(this);
            pbMain.Invalidate();
        }


        /// <summary>
        /// Opens a File Explorer dialog box to upload .csv file with 
        /// predefined order settings and populate the OrderListControls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            HashSet<OrderControl> tempOCremove = new HashSet<OrderControl>();
            foreach (OrderControl oc in ListOfOrdersForms)
            {
                if (oc.TypeItem == "")
                {
                    tempOCremove.Add(oc);
                    OrderListPanel.Controls.Remove(oc);
                }

            }
            ListOfOrdersForms.RemoveAll(x => tempOCremove.Contains(x));

            foreach (Order o in csvh.OrderDetailsUpload())
            {
                OrderControl oc = new OrderControl(wh);
                oc.Width = 1100;
                oc.StartTime = o.TimeStamp;
                oc.TypeItem = o.Type;
                Product p = ProductList.possibleProducts.Find(x => x.Name == o.ItemsList[0].productItem.Name);
                oc.ItemControlList[0].chosenItem = p;
                oc.ItemControlList[0].quantityOfItem = o.ItemsList[0].Quantity;

                for (int i = 1; i < o.ItemsList.Count; i++)
                {
                    oc.OrderItemFlowPanel.Controls.Add(new OrderItemControl());
                    OrderItemControl oic = oc.OrderItemFlowPanel.Controls[i] as OrderItemControl;
                    oic.Name = "oic" + i;
                    oic.Width = 900;
                    Product ps = ProductList.possibleProducts.Find(x => x.Name == o.ItemsList[i].productItem.Name);
                    oic.chosenItem = ps;
                    oic.quantityOfItem = o.ItemsList[i].Quantity;
                    oc.ItemControlList.Add(oic);
                }              

                ListOfOrdersForms.Add(oc);
                OrderListPanel.Controls.Add(oc);
            }

            TabControlMain.SelectedTab = TabPageOrderSettings;

        }


        /// <summary>
        /// Opens the order settings panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {
                OrderControl oc = new OrderControl(wh);
                ListOfOrdersForms.Add(oc);
                OrderListPanel.Controls.Add(oc);
            }
            
            TabControlMain.SelectedTab = TabPageOrderSettings;
                       
        }


        private void btnExtraOrder_Click(object sender, EventArgs e)
        {
            OrderControl oc = new OrderControl(wh);
            ListOfOrdersForms.Add(oc);
            OrderListPanel.Controls.Add(oc);
        }

        /// <summary>
        /// Hides order settings panel without order creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabControlMain.SelectedTab = TabPageSimulation;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            wh.PopulateOrderList(ListOfOrdersForms);
            csvh.SaveToFile();
        }


        /// <summary>
        /// Hides the order settings panel, creates orders from given data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveOrders_Click(object sender, EventArgs e)
        {
            
            wh.ListOrders.Clear();

            wh.PopulateOrderList(ListOfOrdersForms);
            //wh.AssignLinesToAGVs();
                               
            TabControlMain.SelectedTab = TabPageSimulation;
        }


        /// <summary>
        /// Calls the method that starts the simulation, changes the visible controls 
        /// on the left panel to controls relevant to the running simulation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartSim_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "START SIMULATION")
            {
                wh.AGVList.All(x => x.finished = false);
                btnStartSim.Text = "STOP SIMULATION";
                btnStartSim.BackColor = Color.LightCoral;               
                DrawArea = new Bitmap(pbMain.Size.Width, pbMain.Size.Height);
               
                AGVtimer.Enabled = true;
                RandomTimer.Enabled = true;
                wh.StartSimulation();
               // wh.AGVList[1].ShortestPath(200, 200);
               // wh.AGVList[0].ShortestPath(100, 250);
                //wh.AGVList[0].ShortestPath(300, 30);
               // wh.AGVList[0].ShortestPath(20, 200);
            }
            else
                OnStopSimulation();

        }

        int delayCounter = 0;
        
        // the timer checks the direction of the agv and can rotate it
        private void AGVtimer_Tick(object sender, EventArgs e)
        {
            
            pbMain.Refresh();

            foreach (AGV agv in wh.AGVList)
            {
                Graphics g = pbMain.CreateGraphics();
    
                agv.Move(pbMain, g);
             
                busy = false;
                if (agv.PointList.Count == 1)
                {
                    pbMain.BackgroundImage = wh.DrawAreas();
                    pbMain.Invalidate();
                    agv.DoNextRoute();
                    
                }
            }
            if (wh.AGVList.All(x => x.finished == true))
            {
                delayCounter++;
                if (delayCounter == 200)
                {
                    OnStopSimulation();
                    delayCounter = 0;
                }
            }
               
            
        }


        /// <summary>
        /// When the PictureBox is clicked, checks whether a rack, an area or a line had been clicked
        /// and returns the given popup for the object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            int x = 0, y = 0;
            x = e.X;
            y = e.Y;
            if (wh.GetLineDrag(e.X, e.Y) != null && countClicks == 0)
            {
                thisLine = wh.GetLineDrag(e.X, e.Y);
                countClicks++;
            }
            else if (countClicks != 0 && thisLine != null)
            {
                foreach (var r in thisLine.RackList)
                {
                    r.Position = new Point(x, y);
                    x += 40;
                }
                DrawArea = new Bitmap(pbMain.Size.Width, pbMain.Size.Height);
                map = new Map();
                iBlade.map.CreateMap("map", iBlade.wh.Width, iBlade.wh.Height);
                //pbMain.Refresh();
                //pbMain.Invalidate();
                pbMain.BackgroundImage = wh.DrawAreas();
                pbMain.Refresh();
                countClicks = 0;
            }
        }

        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            int n = 3;
            if(rnd.Next(1,10) == n)
            {
                while (true)
                {
                    int index = rnd.Next(0, wh.GetRackList().Count - 1);
                    if (wh.GetRackList()[index].RackStock.Count == 0)
                    {
                        wh.GetRackList()[index].Available = false;
                        busy = true;
                        countBusy++;
                        wh.GetRackList()[index].DrawRack();
                        pbMain.BackgroundImage = wh.DrawAreas();
                        pbMain.Invalidate();
                        break;
                    }
                }
            }
            if (countBusy == 2)
            {
                RandomTimer.Enabled = false;
            }
        }

        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {

            Rack thisRack = wh.GetRack(e.X, e.Y);
            Line thisLine = wh.GetLine(e.X, e.Y);
            Area thisArea = wh.GetArea(e.X, e.Y);
            Area thisAreaInbound = wh.GetArea(e.X, e.Y);
            if (thisRack != null)
            {
                var ProductSetupForm = new ProductsSetup(wh, thisRack, pbMain);
                ProductSetupForm.Show(this);
            }
            else if (thisLine != null)
            {
                var LineSettings = new LineSettingsPopup(thisLine);
                LineSettings.Show(this);
            }
            else if (thisArea != null)
            {
                var AreaSettings = new AreaPopup(thisArea, wh, pbMain);
                AreaSettings.Show(this);
                if (thisArea.Name == "OUTBOUND")
                {
                    foreach (Order o in wh.ListOrders)
                    {
                        if (o.Type == "Outbound")
                        {
                            AreaSettings.listBox1.Items.Add(o.ID + " to be picked up at " + o.TimeStamp.ToString());
                        }
                    }
                    //AreaSettings.listBox1.Items.Clear();
                }

                if (thisArea.Name == "INBOUND")
                {
                    foreach (Order o in wh.ListOrders)
                    {
                        if (o.Type == "Inbound")
                        {
                            AreaSettings.listBox1.Items.Add(o.ID + " to be delivered at " + o.TimeStamp.ToString());
                        }
                    }
                    //AreaSettings.listBox1.Items.Clear();
                }
            }
            
        }

        private void panelMainSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(setSpeed.Value);
            i = 50 - i;
            AGVtimer.Interval = i;
        }


        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Blue, 1);
            SolidBrush fillColor = new SolidBrush(Color.ForestGreen);
            SolidBrush fillColorB = new SolidBrush(Color.RoyalBlue);
            Rectangle settingsEllipse = new Rectangle(25, 80, 30, 30);
            Rectangle settingsEllipseB = new Rectangle(25, 35, 30, 30);
            g.DrawEllipse(myPen, settingsEllipse);
            g.FillEllipse(fillColor, settingsEllipse);
            g.DrawEllipse(myPen, settingsEllipseB);
            g.FillEllipse(fillColorB, settingsEllipseB);
            g.Dispose();
        }
    }
}
