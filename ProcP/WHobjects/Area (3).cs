using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP
{
	public class Area
	{
        public string Name { get; set; }
		public Size Size { get; set; }
		public Point Position { get; set; }
		public List<OrderItem> OrderItemList { get; set; }


        public Area(string name, Point p)
        {
            Name = name;            
            Position = p;
            Size = new Size(150, 100);
        }

        public void DrawArea()
        {

            Graphics g;
            g = Graphics.FromImage(iBlade.DrawArea);
            Font drawFont = new Font("Microsoft Sans Serif", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            Pen myPen = new Pen(Color.Yellow, 5);
            SolidBrush fillColor = new SolidBrush(Color.Yellow);
            Rectangle areaRect = new Rectangle(new Point(Position.X, Position.Y), Size);
            g.FillRectangle(fillColor, areaRect);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(Name, drawFont, drawBrush, areaRect, stringFormat);
            

            g.Dispose();

           // return iBlade.DrawArea;
        }


        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this area.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns></returns>
        public bool ContainsPoint(int xmouse, int ymouse)
        {
            return (xmouse >= Position.X && xmouse <= (Position.X + Size.Width) &&
                (ymouse >= Position.Y && ymouse <= (Position.Y + Size.Height)));
        }
    }
}
