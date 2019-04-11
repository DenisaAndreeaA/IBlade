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
    public partial class AreaPopupInbound : Form
    {
        public Area ar;
        public Warehouse wh;
        public PictureBox mainFormImage;
        public AreaPopupInbound(Area a, Warehouse w, PictureBox img)
        {
            InitializeComponent();
            ar = a;
            wh = w;
            mainFormImage = img;

            mainFormImage.BackgroundImage = wh.DrawAreas();
            mainFormImage.Refresh();
        }
    }
}
