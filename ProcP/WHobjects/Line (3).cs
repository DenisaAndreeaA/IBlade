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
	public class Line
	{
		public int ID { get; set; }
		public List<Rack> RackList { get; set; }
		public Point StartPoint { get; set; }
		private Size LineSize { get; set; }
        public ProductType PriorityProduct { get; set; }
        public Point Position;
        public bool Available { get; set; }


        public Line(int id)
        {
            ID = id;
            RackList = new List<Rack>();
            Position = new Point();
            Available = true;
        }

        public Bitmap DrawLine()
        {
            Graphics g;
            g = Graphics.FromImage(iBlade.DrawArea);
            Pen myPen = new Pen(Color.Blue, 1);
            SolidBrush fillColor = new SolidBrush(Color.ForestGreen);
            SolidBrush fillColorB = new SolidBrush(Color.RoyalBlue);
            Position.X = RackList[0].Position.X - 20;
            Position.Y = RackList[0].Position.Y + 10;
            Rectangle settingsEllipse = new Rectangle(Position.X, Position.Y , 20, 20);
            Rectangle settingsEllipseB = new Rectangle(Position.X + RackList.Count*40+20, Position.Y, 20, 20);
            g.DrawEllipse(myPen, settingsEllipse);
            g.FillEllipse(fillColor, settingsEllipse);
            g.DrawEllipse(myPen, settingsEllipseB);
            g.FillEllipse(fillColorB, settingsEllipseB);
            g.Dispose();
            return iBlade.DrawArea;
        }

        public bool ContainsPoint(int xmouse, int ymouse)
        {
            return (xmouse >= (Position.X + RackList.Count * 40 + 20) && xmouse <= (Position.X + RackList.Count * 40 + 45) &&
                (ymouse >= Position.Y && ymouse <= (Position.Y + 25)));
            
        }

        public bool ContainsPointDrag(int xmouse, int ymouse)
        {
            
            return (xmouse >= Position.X && xmouse <= (Position.X + 25) &&
                (ymouse >= Position.Y && ymouse <= (Position.Y + 25)));
        }

        public Size GetSize()
        {
            int x = this.RackList.Count * Rack.RackSize.Width;
            int y = Rack.RackSize.Height;
            this.LineSize = new Size(x, y);
            return LineSize;
        }
    }
}
