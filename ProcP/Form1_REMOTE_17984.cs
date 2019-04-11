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

            PictureBox pictureOutbound = new PictureBox
            {
                Name = "pictureOutbound",
                Location = new Point(130, 550),
                Image = Properties.Resources.Bound,
                SizeMode = PictureBoxSizeMode.CenterImage
            };
            pbMain.Controls.Add(pictureOutbound);

            PictureBox pictureInbound = new PictureBox
            {
                Name = "pictureOutbound",
                Location = new Point(700, 550),
                Image = Properties.Resources.Bound,
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

                string text = "INBOUND";

                SizeF textSize = ei.Graphics.MeasureString(text, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (pictureInbound.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (pictureInbound.Height / 2) - (textSize.Height / 2);

                ei.Graphics.DrawString(text, Font, Brushes.Black, locationToDraw);
            });

            pictureOutbound.Paint += new PaintEventHandler((sendero, eo) =>
            {
                eo.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                string text = "OUTBOUND";

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
