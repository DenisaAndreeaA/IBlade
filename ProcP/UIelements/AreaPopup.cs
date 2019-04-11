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
    public partial class AreaPopup : Form
    {
        public Area thisArea;
        public Warehouse wh;
        public PictureBox mainFormImage;


        public AreaPopup(Area a, Warehouse w, PictureBox img)
        {
            InitializeComponent();
            thisArea = a;
            wh = w;
            mainFormImage = img;

            
            mainFormImage.BackgroundImage = wh.DrawAreas();
            mainFormImage.Refresh();
        }
    }
}
