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
		public Point Position { get; set; }
		public List<Product> ProductsList { get; set; }

		public Rack(Point p)
		{
			Position = p;
		}



    }
}
