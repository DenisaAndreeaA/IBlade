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
		public int PositionX	 { get; set; }
        public int PositionY { get; set; }
        public int  Speed { get; set; }
		public List<Order> OrderList { get; set; }

        int pictureBoxHeight, pictureBoxWidth;
        public List<Point> PointList = new List<Point>();
        //Bitmap DrawArea;
        Image imageAGV, imageRack;
        public int rotateAngle = 0;
        static int rotated = 0;
        static int angle = 0;
        string rotateDirection = "";
        int X = 500, Y = 50;
        Bitmap AGVD;
        int RackX = 200, RackY = 50;

        public AGV(int pbHeight, int pbWidth)
        {
            pictureBoxHeight = pbHeight;
            pictureBoxWidth = pbWidth;
            PositionX = 500;
            PositionY = 600;
        }

        public Bitmap DrawPoints(int x, int y, int rotatevalue)
        {
            PositionX = x;
            PositionY = y;
            rotated = rotatevalue;

            iBlade.DrawArea = new Bitmap(pictureBoxWidth, pictureBoxHeight);
            Graphics g;
            g = Graphics.FromImage(iBlade.DrawArea);

            Pen mypen = new Pen(Color.Black);
            g.TranslateTransform(x, y);

            g.RotateTransform(rotatevalue);
            g.TranslateTransform(-x, -y);


            g.DrawImage(AGVD, new Point(x, y));

            g.Dispose();


            return iBlade.DrawArea;
        }

        public void LoadImage()
        {
            imageAGV = Properties.Resources.AVG;
            AGVD = ResizeImage(imageAGV, 40, 22);
           
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
            g = Graphics.FromImage(iBlade.DrawArea);

            Pen mypen = new Pen(Color.Black);
            g.TranslateTransform(PositionX, PositionY);

            g.RotateTransform(rotateValue);
            g.TranslateTransform(-PositionX, -PositionY);


            g.DrawImage(AGVD, new Point(PositionX, PositionY));

            g.Dispose();

            return iBlade.DrawArea;


        }

        public void changeDirection(string direction)
        {
            rotateDirection = direction;
            
        }

        public void timerDraw(Timer timer1)
        {
            iBlade.DrawArea = new Bitmap(pictureBoxHeight, pictureBoxHeight);
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
