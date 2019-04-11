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
using ProcP.WHobjects;

namespace ProcP
{
    public class AGV
    {
        public string ID { get; set; }
        public int Capacity { get; set; } //should be implemented later, for now it picks up everything at once
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public List<OrderItem> OrderItemList = new List<OrderItem>();
        public List<Point> PointList = new List<Point>();
        public List<LogEvent> events { get; set; }

        public int rotateAngle = 0;
        Image imageAGV;
        Bitmap AGVD;
        Warehouse wh;
        public bool finished = false;
        int timer = 0;
        Point stopPoint;

        public AGV(int counter, Warehouse w)
        {
            
            ID = "0" + counter.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            events = new List<LogEvent>();
            wh = w;
        }

        public AGV(string id)
        {
            ID = id;
        }

        public Bitmap DrawPoints(int x, int y, int rotatevalue, Graphics g)
        {
            
            Pen mypen = new Pen(Color.Black);
            g.TranslateTransform(x, y);
            g.RotateTransform(rotatevalue);
            g.TranslateTransform(-x, -y);
            g.DrawImage(AGVD, new Point(x, y));
            //g.Save();
            //g.Dispose();
            //iBlade.DrawArea = AGVD;

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



        //public void Move(PictureBox pbMain, Statistics stats, Graphics g)
        public void Move(PictureBox pbMain, Graphics g)
        {
            //if (busy && PointList.Count > 0)
            //{
            //    int x, y;
            //    x = PointList[PointList.Count - 1].X;
            //    y = PointList[PointList.Count - 1].Y;
            //    PointList.Clear();
            //    ShortestPath(x, y);
            //}
            if (PointList[0] == stopPoint && timer < 30)
            {
                
                timer++;
                int closein = 50 - timer;
                this.DrawPoints(PointList[0].X - 15, PointList[0].Y + closein, -90, g);

            }
            else if (PointList.Count > 1)
            {
                timer = 0;
                if (PointList[0].X < PointList[1].X && PointList[0].Y < PointList[1].Y) this.rotateAngle = 45;
                else if (PointList[0].X == PointList[1].X && PointList[0].Y < PointList[1].Y) this.rotateAngle = 90;
                else if (PointList[0].X == PointList[1].X && PointList[0].Y > PointList[1].Y) this.rotateAngle = -90;
                else if (PointList[0].X > PointList[1].X && PointList[0].Y > PointList[1].Y) this.rotateAngle = -135;
                else if (PointList[0].X < PointList[1].X && PointList[0].Y < PointList[1].Y) this.rotateAngle = -45;
                else if (PointList[0].X < PointList[1].X && PointList[0].Y > PointList[1].Y) this.rotateAngle = -45;
                else if (PointList[0].X > PointList[1].X && PointList[0].Y < PointList[1].Y) this.rotateAngle = 135;
                else if (PointList[0].X < PointList[1].X && PointList[0].Y == PointList[1].Y) this.rotateAngle = 0;
                else if (PointList[0].X > PointList[1].X && PointList[0].Y == PointList[1].Y) this.rotateAngle = 180;

                if (PointList.Count > 9)
                this.DrawPoints(PointList[0].X, PointList[0].Y, this.rotateAngle, g);
                PointList.RemoveAt(0);
            }

        }

        public void DoNextRoute()
        {

            if (this.OrderItemList.Count != 0)
            {
                OrderItem oi = this.OrderItemList[0];
                if (oi.Type == "Inbound")
                {
                    foreach (Rack r in wh.GetPossibleRacksForAGV(this, oi))
                    {

                        if (r.RackStock.Sum(x => x.Quantity) + oi.Quantity <= 10 && r.Available == true)
                        {
                            this.PickUpOrderItem(wh.AreaList[0], oi); //orderstatus changes to PICKEDUP
                            this.DropOrderItem(r, oi); //navigates to the rack and adds item to racks list                                 
                            break;
                        }
                    }
                    this.OrderItemList.Remove(oi);
                }
                else if (oi.Type == "Outbound")
                {
                    if (wh.GetRacksWithOrderItem(oi).Count == 0)
                    {
                        if (wh.AGVList.Any(x => x.OrderItemList.Any(o => o.Type == "Inbound")))
                            this.PointList.Add(new Point(PositionX, PositionY));
                        else
                            MessageBox.Show("The outbound orders can not be delivered; there's nothing on the racks.");

                    }
                    else
                    {
                        List<Rack> lr = wh.GetRacksWithOrderItem(oi);
                        if (lr[0].RackStock.Exists(x => x.productItem == oi.productItem
                            && x.Quantity >= oi.Quantity))
                        {
                            lr[0].RackStock.Find(x => x.productItem == oi.productItem 
                            && x.Quantity >= oi.Quantity).Quantity -= oi.Quantity;
                            oi.Quantity = 0;
                            this.PickUpOrderItem(lr[0], oi);
                        }
                        else
                        {
                            for (int i = 0; i < lr.Count(); i++)
                            {
                                foreach (OrderItem stock in lr[i].RackStock)
                                {
                                    if (oi.Quantity != 0 && stock.productItem == oi.productItem)
                                    {
                                        if (stock.Quantity - oi.Quantity >= 0)
                                        {
                                            stock.Quantity -= oi.Quantity;
                                            oi.Quantity = 0;
                                        }
                                        else
                                        {
                                            oi.Quantity -= stock.Quantity;
                                            stock.Quantity = 0;
                                        }
                                        this.PickUpOrderItem(lr[i], oi);
                                    }
                                }
                            }

                        }
                            
                         oi.PickUpTime = DateTime.Now; // registers the pickup time of the order
                         this.DeliverOrderItem(wh.AreaList[1], oi);
                         this.OrderItemList.Remove(oi);                                                  
                    }

                }
                
            }
            else
            {
                ShortestPath(10, 100);
                finished = true;
            }

        }


        public void ShortestPath(int x, int y)
        {
            
            Point point1 = new Point(this.PositionX, this.PositionY);
            Point point2 = new Point(x, y);
            PositionX = x*5;
            PositionY = y*5;

            if (point1 != point2)
            {
                PathCalculator path = new PathCalculator(iBlade.map.TilesArray);
                List<Tile> tilelist = new List<Tile>();

                tilelist = path.FindShortestPath(point1, point2);

                foreach (Tile t in tilelist)
                {
                    this.PointList.Add(t.Pixel);
                }
            }
            else Console.WriteLine("The AGV doesn't have to move");
            iBlade.Status = true;
        }



        /// <summary>
        /// the given OrderItem is brought from inbound to the rack
        /// </summary>
        /// <param name="r"></param>
        public void DropOrderItem(Rack r, OrderItem oi)
        {
            
            ShortestPath((r.Position.X / 5) + 5, (r.Position.Y / 5) + 10);
            if (PointList.Count > 2)
                stopPoint = PointList[PointList.Count-2];
            oi.Status = OIStatus.ONRACK;
            r.RackStock.Add(oi);           
            LogEvent le = new LogEvent(r.Position, this, oi, OIStatus.ONRACK);
            oi.TimeFulfilled = DateTime.Now;
            le.Time = oi.TimeFulfilled;
            le.Rack = r;
            events.Add(le);
            Console.WriteLine($"{ID} drops {oi.productItem.Name} to rack at {r.Position.X}, {r.Position.Y}");
        }


        /// <summary>
        /// Orderitem is moved to outbound
        /// </summary>
        /// <param name="a"></param>
        /// <param name="oi"></param>
        public void DeliverOrderItem(Area a, OrderItem oi)
        {
            string agvnr = ID.Substring(0,2);
            ShortestPath(110, 100); //goes to outbound
            
            oi.Status = OIStatus.OUTBOUND;
            LogEvent le = new LogEvent(a.Position, this, oi, OIStatus.OUTBOUND);
            le.Area = a;
            oi.TimeFulfilled = DateTime.Now;
            le.Time = oi.TimeFulfilled;
            events.Add(le);
            Console.WriteLine($"{ID} delivered order {oi.productItem.Name} to outbound");
        }

        /// <summary>
        /// AGV picks up an orderItem from rack to bring to Outbound
        /// </summary>
        /// <param name="r"></param>
        /// <param name="oi"></param>
        public void PickUpOrderItem(Rack r, OrderItem oi)
        {
            
            ShortestPath((r.Position.X/5) + 5, (r.Position.Y/5)+10); //goes to rack
            if(PointList.Count > 2)
                stopPoint = PointList[PointList.Count - 2];
            oi.Status = OIStatus.PICKEDUP;         
            r.DrawRack();
            oi.PickUpTime = DateTime.Now;
            LogEvent le = new LogEvent(r.Position, this, oi, OIStatus.PICKEDUP);
            le.Time = oi.PickUpTime;
            le.Rack = r;
            events.Add(le);
            Console.WriteLine($"{ID} delivered order {oi.productItem.Name} to outbound");
        }


        /// <summary>
        /// AGV picks up an orderItem from Inbound
        /// </summary>
        /// <param name="a"></param>
        /// <param name="oi"></param>
        public void PickUpOrderItem(Area a, OrderItem oi)
        {
            oi.Status = OIStatus.PICKEDUP;
            oi.PickUpTime = DateTime.Now;
            LogEvent le = new LogEvent(a.Position, this, oi, OIStatus.PICKEDUP);
            le.Time = oi.PickUpTime;
            le.Area = a;
            events.Add(le);

        }

        // this method uses the PathCalculator class to calculate the shortest path between 2 points and saves the path into a list
        // then put that list in the agv object


    }

    public class LogEvent
    {

        public LogEvent(Point p, AGV agv, OrderItem oi, OIStatus st)
        {
            Place = p;
            Agv = agv;
            OI = oi;
            Status = st;
        }

        public LogEvent()
        {
        }

        public DateTime Time { get; set; }
        public Point Place { get; set; }
        public OrderItem OI { get; set; }
        public Area Area { get; set; }
        public Rack Rack { get; set; }
        public AGV Agv { get; set; }
        public OIStatus Status { get; set; }
    }
}
