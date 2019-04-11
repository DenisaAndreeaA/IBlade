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
	class Line
	{
		public int ID { get; set; }
		public List<Rack> RackList { get; set; }
		public Point StartPoint { get; set; }
		public int Size { get; set; }
        Image imageLine1;
        Bitmap Line1;
        public Line()
        {
            RackList = new List<Rack>();
            imageLine1 = Properties.Resources.Line1;
            Line1 = ResizeImage(imageLine1, 300, 70);
        }

        Bitmap RackD;
        public Bitmap DrawLine(int RackX, int RackY)
        {

            Graphics g;
            g = Graphics.FromImage(iBlade.DrawArea);

            Pen mypen = new Pen(Color.Black);

            g.DrawImage(imageLine1, new Point(RackX, RackY));

            g.Dispose();

            return iBlade.DrawArea;


        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

    }
}
