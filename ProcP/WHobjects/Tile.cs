using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP.WHobjects
{
    public class Tile
    {
        // ---------------------- Fields -----------------------
        protected Point location;

        // -------------------- Properties ---------------------
        public Point Location { get { return location; } }
        public Point Pixel { get; set; }

        // -------------------- Constructor --------------------

        public Tile(Point location, Point pixel)
        {
            this.location = location;
            Pixel = pixel;
        }
        public Tile( Point pixel)
        {
            //this.location = location;
            Pixel = pixel;
        }

        public Tile() // Required in sub-classes
        {

        }
    }
}
