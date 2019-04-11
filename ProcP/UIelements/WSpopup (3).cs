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
using ProcP.WHobjects;

namespace ProcP
{
	public partial class WSpopup : Form
	{
		public Warehouse wh; // stores the warehouse object from Form1.cs
		public PictureBox mainFormImage;
		

        public WSpopup(Warehouse w, PictureBox img)
        {
            InitializeComponent();
			wh = w;
			mainFormImage = img;
        }

        private void btnWSsave_Click(object sender, EventArgs e)
        {

            wh.AGVList.Clear();
            int noOfRacks = Convert.ToInt32(numericUpDown3.Value);
            int noOfRacksperLine = Convert.ToInt32(numericUpDown4.Value);
            int noOfAgv = Convert.ToInt32(numericUpDown5.Value);

            wh.CreateLines(noOfRacks, noOfRacksperLine);
            wh.AGVList.Clear();
            for(int i=0; i<noOfAgv; i++)
            {
                AGV agv = new AGV( i , wh);
                wh.AGVList.Add( agv );               
            }

            if (checkBoxSave.Checked)
            {
                CsvHandler csvh = new CsvHandler(wh);
                csvh.SaveWHSpecsToFile(numericUpDown3.Value.ToString(),numericUpDown4.Value.ToString(),numericUpDown5.Value.ToString());
            }

            
            this.Close();
            
            mainFormImage.BackgroundImage = wh.DrawAreas();
            mainFormImage.Refresh();
           
            iBlade.map.CreateMap("map", iBlade.wh.Width, iBlade.wh.Height);
            // wh.AGVList[0].ShortestPath(300, 299, "");

            //refresh the picture box when setting warehouse specificaions
            //iBlade mainForm = new iBlade();
            //mainForm.pbMain.Refresh();
            
        }

        private void btnWSupload_Click(object sender, EventArgs e)
        {
            iBlade.csvh.WHSpecsUpload();

            
        }

    }
}
