using ProcP.UIelements;
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

namespace ProcP
{
	public partial class iBlade : Form
	{
        private Warehouse wh;

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

           
            for (int i = 0; i < 10; i++)
            {
                flowLayoutPanel1.Controls.Add(new OrderItemData());
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
            startSimulation();

            SimulationControlPanel duringSimPanel = new SimulationControlPanel();
            this.Controls.Add(duringSimPanel);
            duringSimPanel.Location = new Point(10, 34);
            duringSimPanel.BringToFront();
            
            duringSimPanel.OnStopSim += (s, ec) => OnStopSimulation(duringSimPanel);

            //Image img = Image.FromFile("C:/Users/denis/Desktop/ProCp/ProcP/ProcP/Resources/Rack.jpg");

            //pbMain.Image = img;

            
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(100, 50),
                Location = new Point(14, 17),
                Image = Properties.Resources.Rack,
                SizeMode = PictureBoxSizeMode.CenterImage
                
                
            };
            pbMain.Controls.Add(picture1);

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
    }
}
