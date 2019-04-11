using CsvHelper;
using ProcP.UIelements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP
{
    public class Warehouse
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Line> LinesList { get; set; }
        public List<Area> AreaList { get; set; }
        public List<AGV> AGVList { get; set; }
        public List<OrderControl> ListOfOrdersForm;
        public List<Order> ListOrders = new List<Order>(); //List of saved orders
        public List<string> eventlog;
        Area inbound;
        Area outbound;
        PictureBox pbMain;



        public Warehouse(PictureBox pbMain)
        {
            AGVList = new List<AGV>();
            LinesList = new List<Line>();
            AreaList = new List<Area>();
            Height = pbMain.Size.Height;
            Width = pbMain.Size.Width;
            inbound = new Area("INBOUND", new Point(40, 500));
            outbound = new Area("OUTBOUND", new Point(500, 500));
            this.AreaList.Add(inbound);
            this.AreaList.Add(outbound);
            eventlog = new List<string>();
            this.pbMain = pbMain;
        }

        public Bitmap DrawAreas()
        {          
            
            AreaList.ForEach( x => x.DrawArea());
            LinesList.ForEach(x => x.DrawLine());
            GetRackList().ForEach(x => x.DrawRack());
            AGVList.ForEach(x => x.LoadImage());
            
            return iBlade.DrawArea;
        }


        /// <summary>
        /// According to the settings in WSpopup, creates lines and populates it with racks
        /// </summary>
        public void CreateLines(int noOfRacks, int noOfRacksperLine)
        {
            Point p = new Point(30, 10);
            char[] LineID = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            int numberOfLines = noOfRacks / noOfRacksperLine;
            if (noOfRacks % noOfRacksperLine >= 0)
                ++numberOfLines;

            int rackCounter = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                Line line = new Line(i);
                for (int j = 0; j < noOfRacksperLine; j++)
                {
                    if (rackCounter == noOfRacks) break;
                    string id = LineID[i].ToString() + "-" + j.ToString();
                    Rack r = new Rack(p, id);
                    line.RackList.Add(r);
                    rackCounter++;
                    p.X += 40;
                }
                this.LinesList.Add(line);

                if (rackCounter == noOfRacks) break;

                if (p.X >= pbMain.Size.Width / 2)
                {
                    p.X = 30;
                    p.Y += 100;
                }
                else
                {
                    p.X += 150;
                }
            }
        }

        /// <summary>
        /// If this warehouse has a rack that contains the point (xmouse,ymouse),
        /// then that rack is returned, else null is returned
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        public Rack GetRack(int xmouse, int ymouse)
        {
            foreach (Line l in this.LinesList)
            {
                foreach (Rack r in l.RackList)
                {
                    if (r.ContainsPoint(xmouse, ymouse)) { return r; }
                }
            }
            return null; //to satisfy the compiler
        }

        /// <summary>
        /// If this warehouse has a line that contains the point (xmouse,ymouse),
        /// then that line is returned, else null is returned
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        public Line GetLine(int xmouse, int ymouse)
        {
            foreach (Line l in LinesList)
            {
                if (l.ContainsPoint(xmouse, ymouse)) { return l; }
            }

            return null; //to satisfy the compiler
        }
        public Line GetLineDrag(int xmouse, int ymouse)
        {
            foreach (Line l in LinesList)
            {
                if (l.ContainsPointDrag(xmouse, ymouse)) { return l; }
            }

            return null; //to satisfy the compiler
        }

        public Area GetArea(int xmouse, int ymouse)
        {
            foreach (Area a in AreaList)
            {
                if (a.ContainsPoint(xmouse, ymouse)) { return a; }
            }

            return null; //to satisfy the compiler
        }

        public List<Rack> GetRackList()
        {
            List<Rack> rackList = new List<Rack>();
            foreach (Line l in LinesList)
                rackList.AddRange(l.RackList);
            return rackList;
        }


        /// <summary>
        /// After setting the orders, this method actually creates the orderItems and the containing orders
        /// </summary>
        /// <param name="ListOfOrdersForm"></param>
        public void PopulateOrderList(List<OrderControl> ListOfOrdersForm)
        {
            int counter = 0;
            foreach (OrderControl od in ListOfOrdersForm)
            {
                if (od.TypeItem != "")
                {
                    Order newOrder;
                    List<OrderItem> itemslist = new List<OrderItem>();
                    foreach (OrderItemControl oc in od.ItemControlList)
                    {
                        if (oc.chosenItem != null && oc.quantityOfItem != 0)
                        {
                            OrderItem oi = new OrderItem(oc.chosenItem, oc.quantityOfItem, od.TypeItem);
                            
                            if (od.TypeItem == "Inbound")
                                oi.Status = OIStatus.INBOUND;
                            else oi.Status = OIStatus.ONRACK;

                            itemslist.Add(oi);
                        }
                    }
                    newOrder = new Order(counter++, od.TypeItem, od.StartTime, itemslist);
                    ListOrders.Add(newOrder);

                }
            }
            
        }

        public void AssignOrderItemsToAgvs()
        {
            //all orderItems added to one list for simplicity
            List<OrderItem> allOrderItem = new List<OrderItem>();
            for (int i = 0; i <= ListOrders.Count - 1; i++)
            {
                for (int j = 0; j <= ListOrders[i].ItemsList.Count - 1; j++)
                {
                    allOrderItem.Add(ListOrders[i].ItemsList[j]);
                }
            }

            List<OrderItem> SortedItems = allOrderItem.OrderBy(o => o.productItem.Type).ToList();
            int ItemsPerAGV = SortedItems.Count / AGVList.Count;
            foreach (AGV agv in AGVList)
            {
                agv.OrderItemList.AddRange(SortedItems.Take(ItemsPerAGV));
                SortedItems.RemoveRange(0,ItemsPerAGV);
            }
            if (SortedItems.Count != 0)
                AGVList.Last().OrderItemList.AddRange(SortedItems);
            AGVList.ForEach(x => x.OrderItemList.OrderBy(o => o.Type));
        }




        /// <summary>
        /// Returns a list of racks, the first ones are in lines that have prio, than the other lists
        /// </summary>
        /// <param name="agv"></param>
        /// <returns></returns>
        public List<Rack> GetPossibleRacksForAGV(AGV agv, OrderItem oi)
        {
            List<Rack> racklist = new List<Rack>();
            List<Rack> prioRackList = new List<Rack>();
            List<Line> sortedLines = LinesList.OrderByDescending(x => x.Position.Y).ToList();
            foreach (Line l in sortedLines)
            {

                    if (l.PriorityProduct == oi.productItem.Type)
                    {
                        foreach (Rack r in l.RackList)
                        {
                            if (r.Available == true)
                                prioRackList.Add(r);
                        }
                    }

                    else
                        foreach (Rack r in l.RackList)
                        {
                            if (r.Available == true)
                                racklist.Add(r);
                        }

            }

            racklist.InsertRange(0, prioRackList);
            return racklist;
        }




        public void StartSimulation()
        {
            AssignOrderItemsToAgvs();
            for (int i = 0; i < AGVList.Count; i++)
            {
                AGVList[i].PositionX = AreaList[0].Position.X + (i*40);
                AGVList[i].PositionY = AreaList[0].Position.Y;
                Console.WriteLine("Agv went into startsim: " + AGVList[i].ID);
                AGVList[i].DoNextRoute();
                
            }
        }





        /// <summary>
        /// Returns a list of racks that contain the given product in at least the given quantity
        /// </summary>
        /// <param name="oi"></param>
        /// <returns></returns>
        public List<Rack> GetRacksWithOrderItem(OrderItem oi)
        {
            List<Rack> lr = new List<Rack>();
            foreach (Rack r in this.GetRackList())
            {
                if (r.RackStock.Exists(x => x.productItem == oi.productItem) &&
                    r.RackStock.Exists(x => x.Quantity >= oi.Quantity) && r.Available == true)
                    lr.Add(r);
                                   
            }
            //in case there are enough items on the racks, but divided on more than 1 rack
            if (lr.Count == 0)
            {
                foreach (Rack r in this.GetRackList())
                {
                    if (r.RackStock.Exists(x => x.productItem == oi.productItem) &&
                        r.RackStock.Exists(x => x.Quantity < oi.Quantity) && r.Available == true)
                        lr.Add(r);

                }
            }
            return lr;
            
        }


        /// <summary>
        /// Creates 5 OrderControls when the set orders button is clicked
        /// </summary>
        /// <returns></returns>
        public List<OrderControl> SetOrders()
        {
            ListOfOrdersForm = new List<OrderControl>();

            for (int i = 0; i < 5; i++)
            {
                OrderControl oc = new OrderControl(this);
                ListOfOrdersForm.Add(oc);
            }
            return ListOfOrdersForm;
        }


    }
}
