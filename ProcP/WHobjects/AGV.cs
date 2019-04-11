using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Windows.Forms;

namespace ProcP
{
	class AGV
	{
		public int ID { get; set; }
		public int Capacity { get; set; }
		public int Position	 { get; set; }
		public int  Speed { get; set; }
		public List<Order> OrderList { get; set; }

        int pictureBoxHeight, pictureBoxWidth;

        Bitmap DrawArea;
        Image imageAGV, imageRack;
        int rotateAngle = 0;
        static int rotated = 0;
        static int angle = 0;
        string rotateDirection = "";
        int X = 500, Y = 50;
        Bitmap AGVD;
        Bitmap Rack;
        int RackX = 200, RackY = 50;


        public void LoadImage()
        {
            imageAGV = Properties.Resources.AGV;
            imageRack = Properties.Resources.Rack;
            AGVD = ResizeImage(imageAGV, 40, 22);
            Rack = ResizeImage(imageRack, 300, 70);
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

        public Bitmap DrawAGV(float rotateValue)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Black);
            g.TranslateTransform(X, Y);

            g.RotateTransform(rotateValue);
            g.TranslateTransform(-X, -Y);


            g.DrawImage(AGVD, new Point(X, Y));

            return DrawArea;

            g.Dispose();
        }

        public void timerDraw(Timer timer1)
        {
            DrawArea = new Bitmap(pictureBoxHeight, pictureBoxHeight);
            if (rotateDirection == "right" && rotateAngle <= rotated)
            {
                DrawAGV(rotateAngle);
                //DrawRack();
                rotateAngle++;
                if (rotateAngle == rotated)
                {
                    timer1.Enabled = false;
                    rotated = 0;
                    angle += 90;
                    if (angle == 360)
                    {
                        angle = 0;
                        rotateAngle = 0;
                    }
                }
            }
            if (rotateDirection == "none")
            {
                if ((angle == 90 || angle == -270) && Y < pictureBoxHeight - 22 && ((Y >= RackY + 70 || Y <= RackY) || (X < RackX || X > RackX + 300)))
                {
                    Y++;
                }
                else if ((angle == 0) && X < pictureBoxWidth - 40 && ((Y >= RackY + 70 || Y <= RackY) || (X < RackX || X > RackX + 300)))
                {
                    X++;
                }
                else if ((angle == 180 || angle == -180) && X > 40 && ((Y >= RackY + 70 || Y <= RackY) || (X < RackX || X > RackX + 300)))
                {
                    X--;
                }
                else if ((angle == -90 || angle == 270) && Y > 35 && ((Y >= RackY + 70 || Y <= RackY) || (X < RackX || X > RackX + 300)))
                {
                    Y--;
                }

                DrawAGV(rotateAngle);
               // DrawRack();
            }
            if (rotateDirection == "left" && rotateAngle >= rotated)
            {
                DrawAGV(rotateAngle);
               // DrawRack();
                rotateAngle--;
                if (rotateAngle == rotated)
                {
                    timer1.Enabled = false;
                    rotated = 0;
                    angle -= 90;
                    if (angle == -360)
                    {
                        angle = 0;
                        rotateAngle = 0;
                    }
                }
            }
        }

    }
}
