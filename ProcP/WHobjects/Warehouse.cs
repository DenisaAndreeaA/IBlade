using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP
{
	class Warehouse
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public List<Line> LinesList { get; set; }
		public List<AGV> AGVList { get; set; }

        public void DrawAreas()
        { }



	}
}
