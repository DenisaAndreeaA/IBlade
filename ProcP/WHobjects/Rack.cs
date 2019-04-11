using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP
{
	class Rack
	{
		public int ID { get; set; }
		public int Size { get; set; }
		public List<Product> ProductsList { get; set; }

        Bitmap DrawArea;
        Bitmap RackD;
        int RackX = 200, RackY = 50;
        public Bitmap DrawRack()
        {

            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Black);

            g.DrawImage(RackD, new Point(RackX, RackY));

            return DrawArea;

            g.Dispose();
        }

    }
}
