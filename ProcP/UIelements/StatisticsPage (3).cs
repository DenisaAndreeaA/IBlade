using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using ProcP.WHobjects;
using System.Windows.Media;
using LiveCharts.Configurations;

namespace ProcP.UIelements
{
    public partial class StatisticsPage : UserControl
    {
        Warehouse wh;
        public List<DateTime> PickupTimes;
        public List<LogEvent> oldEvents;

        public StatisticsPage()
        {
            InitializeComponent();
            PickupTimes = new List<DateTime>();
            
        }

        public TabControl statsTabControl
        {
            get { return tabControl1; }
            set { tabControl1 = value; }
        }

        public void CreateCharts(Warehouse w)
        {
            wh = w;

            #region ------------------overview page----------------
            ordersInTimeChart.Series.Clear();
            ordersInTimeChart.AxisX.Clear();
            ordersInTimeChart.AxisY.Clear();
            barChartOutIn.Series.Clear();
            barChartOutIn.AxisX.Clear();
            barChartOutIn.AxisY.Clear();


            //top chart to show inbound / outbound
            barChartOutIn.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Inbound",
                    Values = new ChartValues<double> { wh.ListOrders.SelectMany(x => x.ItemsList.Where(o => o.Type == "Inbound")).Count() }
                },
                new ColumnSeries
                {
                Title = "Outbound",
                Values = new ChartValues<double> { wh.ListOrders.SelectMany(x => x.ItemsList.Where(o => o.Type == "Outbound")).Count() }
                }

            };

            barChartOutIn.AxisY.Add(new Axis
            {
                Title = "Number of order items",

            });
            barChartOutIn.AxisX.Add(new Axis
            {
                Title = "Areas",
                Labels = new[] { "Inbound", "Outbound" }
            });

            //orders delivered shown on timeline
            var timeConfig = Mappers.Xy<LogEvent>()
            .X(le => le.Time.Ticks / TimeSpan.FromSeconds(1).Ticks)
            .Y(le => le.OI.Quantity);

            ordersInTimeChart.Series = new SeriesCollection(timeConfig) { };
            
            
            foreach (AGV agv in wh.AGVList)
            {
                ordersInTimeChart.Series.Add(new LineSeries
                {
                    Title = agv.ID,
                    Values = new ChartValues<LogEvent>(agv.events),
                    LineSmoothness = 0, //straight lines, 1 really smooth lines                
                    PointGeometrySize = 10,
                    PointForeground = System.Windows.Media.Brushes.LightSeaGreen
                });

                //List<double> delList = new List<double>();
                //foreach (LogEvent le in agv.events)
                //{
                //    delList.Add(le.OI.Quantity);
                //}

                //ordersInTimeChart.Series.Add(new LineSeries
                //{
                //    Title = agv.ID,
                //    Values = new ChartValues<double> ( delList ),
                //    LineSmoothness = 0, //straight lines, 1 really smooth lines                
                //    PointGeometrySize = 10,
                //    PointForeground = System.Windows.Media.Brushes.LightSeaGreen
                //});
            }

            //List<string> tps = new List<string>();
            //foreach (var timepoint in wh.AGVList.Last().events)
            //{
            //    tps.Add(timepoint.Time.ToLongTimeString());
            //}

            ordersInTimeChart.AxisX.Add(new Axis
            {
                Title = "Time",
                LabelFormatter = value => new DateTime((long) (value*TimeSpan.FromSeconds(1).Ticks)).ToLongTimeString()
            });

            ordersInTimeChart.AxisY.Add(new Axis
            {
                Title = "Delivered orders",
                LabelFormatter = value => value.ToString()
            });

            ordersInTimeChart.LegendLocation = LegendLocation.Right;




            
            #endregion



            #region--------------------AGV performance page-----------------
            pieChart1.Series.Clear();


            //PieChart with OrderItems/AGV
            Func<ChartPoint, string> labelPoint = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection { };

            List<AGV> ListOfAGVs = wh.AGVList;
            foreach (AGV agv in ListOfAGVs)
            {
                pieChart1.Series.Add(
                    new PieSeries
                    {
                        Title = agv.ID,
                        Values = new ChartValues<double> { agv.events.Count/2 },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });
            }

            pieChart1.LegendLocation = LegendLocation.Bottom;

            //SolidGauge to show delivered orderItems of the AGV per all orderItems
            int totalOrderItems = wh.ListOrders.Sum(x => x.ItemsList.Count);
            foreach (AGV agv in wh.AGVList)
            {
                GroupBox gb = new GroupBox();
                gb.Text = agv.ID;
                gb.Size = new Size(250, 200);

                SolidGauge solidGauge = new SolidGauge();
                
                solidGauge.From = 0;
                solidGauge.To = totalOrderItems;
                solidGauge.Value = agv.OrderItemList.Count;
                solidGauge.Padding = new Padding(30,30,30,30);
                solidGauge.Anchor = AnchorStyles.None;

                Label lbl = new Label();
                lbl.Padding = new Padding(20,20,20,0);
                lbl.Text = "AGV delivery / all delivery";
                
                gb.Controls.Add(lbl);
                gb.Controls.Add(solidGauge);
                
                FlowPanelAGV.Controls.Add(gb);
            }

            #endregion
        }

        public void CreateComparison()
        {
            compBarChart.Series.Clear();
            compPieChartNew.Series.Clear();
            compPieChartOld.Series.Clear();
            //top chart to show inbound / outbound
            compBarChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Inbound (Old)",
                    Values = new ChartValues<double> {oldEvents.Where(x => x.OI.Type == "Inbound").Count() }
                },
                new ColumnSeries
                {
                    Title = "Outbound (Old)",
                    Values = new ChartValues<double> { oldEvents.Where(x => x.OI.Type == "Outbound").Count() }
                },
                new ColumnSeries
                {
                    Title = "Inbound (New)",
                    Values = new ChartValues<double> { wh.ListOrders.Where(x => x.Type == "Inbound").Count() }
                },
                new ColumnSeries
                {
                    Title = "Outbound (New)",
                    Values = new ChartValues<double> { wh.ListOrders.Where(x => x.Type == "Outbound").Count() }
                }
            };
         
            compBarChart.AxisY.Add(new Axis
            {
                Title = "Number of order items",

            });

            //PieChart with OrderItems/AGV old
            Func<ChartPoint, string> labelPoint2 = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            compPieChartOld.Series = new SeriesCollection { };

            List<AGV> ListOfAGVsOld = oldEvents.Select(o => o.Agv).Distinct().ToList();
            foreach (AGV agv in ListOfAGVsOld)
            {
                compPieChartOld.Series.Add(
                    new PieSeries
                    {
                        Title = agv.ID,
                        Values = new ChartValues<double> { oldEvents.Select(o => o.Agv.ID == agv.ID).Count() / 2 },
                        DataLabels = true,
                        LabelPoint = labelPoint2
                    });
            }

            //PieChart with OrderItems/AGV new
            Func<ChartPoint, string> labelPoint3 = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            compPieChartNew.Series = new SeriesCollection { };

            List<AGV> ListOfAGVs = wh.AGVList;
            foreach (AGV agv in ListOfAGVs)
            {
                compPieChartNew.Series.Add(
                    new PieSeries
                    {
                        Title = agv.ID,
                        Values = new ChartValues<double> { agv.events.Count / 2 },
                        DataLabels = true,
                        LabelPoint = labelPoint3
                    });
            }
        }

        private void btnSaveOverview_Click(object sender, EventArgs e)
        {
            CsvHandler csvh = new CsvHandler(wh);
            csvh.SaveOverview();
        }

        private void btnUploadOverview_Click(object sender, EventArgs e)
        {
            CsvHandler csvh = new CsvHandler(wh);
            oldEvents = csvh.UploadOverview();
            //oldEvents.ForEach(x => Console.WriteLine($"{x.Agv}, {x.OI.productItem.FullName}, {x.OI.Quantity}, {x.OI.Type}, {x.Time}, {x.Status}"));
            CreateComparison();
        }



        private List<DateTime> GetPickupTimes()
		{
            PickupTimes.Clear();
			foreach (var o in wh.ListOrders)
				foreach (var oi in o.ItemsList)
					PickupTimes.Add(oi.PickUpTime);
			return PickupTimes;
		}

        
    }

}
