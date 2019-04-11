using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP.WHobjects
{
    class TileRack: Tile
    {
        public TileRack(Point location, Point pixel)
        {
            this.location = location;
            Pixel = pixel;
        }
    }
}
