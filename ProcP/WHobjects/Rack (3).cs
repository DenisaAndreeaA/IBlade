using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ProcP
{
	public class Rack
	{
		public string ID { get; set; }
        public static Size RackSize { get; set; } = new Size( 40, 40 );
		public Point Position { get; set; }
        public List<OrderItem> RackStock { get; set; } 
        public bool Available { get; set; }
		

		public Rack(Point p, string id)
		{
			Position = p;
			ID = id;
            RackStock = new List<OrderItem>();
            Available = true;
        }


		public Bitmap DrawRack()
		{

			Graphics g;
			g = Graphics.FromImage(iBlade.DrawArea);
            Font drawFont = new Font("Microsoft Sans Serif", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            SolidBrush drawBrushB = new SolidBrush(Color.MediumVioletRed);
            SolidBrush fillBrush = new SolidBrush(Color.LightSkyBlue);
            SolidBrush fillBrushB = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black, 4);
            Rectangle rackRect = new Rectangle( new Point( Position.X, Position.Y ), RackSize );
            
            if (this.RackStock.Count != 0)
            {
                
                g.FillRectangle(fillBrush, rackRect);
                g.DrawString(this.RackStock.Sum(x => x.Quantity).ToString() + " items", new Font("Microsoft Sans Serif", 6), drawBrushB, Position.X + 1, Position.Y + 1);
            }
            else g.FillRectangle(new SolidBrush(Color.Transparent), rackRect);
            
            if (Available == false)
            {
                g.FillRectangle(fillBrushB, rackRect);
            }
            g.DrawRectangle(myPen, rackRect);
            g.DrawString(ID.ToString(), drawFont, drawBrush, Position.X + 3, Position.Y + 10);           
			g.Dispose();

			return iBlade.DrawArea;
		}

        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this area.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns></returns>
        public bool ContainsPoint(int xmouse, int ymouse)
        {
            return (xmouse >= Position.X && xmouse <= (Position.X + RackSize.Width) &&
                (ymouse >= Position.Y && ymouse <= (Position.Y + RackSize.Height)));
        }

      



    }
}
