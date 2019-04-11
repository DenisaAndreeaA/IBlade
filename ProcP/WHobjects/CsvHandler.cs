using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP.WHobjects
{
    public class CsvHandler
    {

        

        public Warehouse wh;

        public CsvHandler(Warehouse w)
        {
            wh = w;
        }


        public void WHSpecsUpload()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    reader.ReadLine();
                    List<string> result = new List<string>();
                    string value;
                    var csv = new CsvReader(reader);
                    csv.Configuration.HasHeaderRecord = true;
                    while (csv.Read())
                    {
                        for (int i = 0; csv.TryGetField<string>(i, out value); i++)
                        {
                            result.Add(value);
                        }
                    }
                }
            }
        }

        public void SaveWHSpecsToFile(string numberOfRacks, string numberOfRacksPerLine, string numberOfAGVs)
        {
           
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv*)|*.csv*";
                sfd.DefaultExt = "csv";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;

                    //string filePath = @"../../WarehouseSpecificationsFile.csv";
                    string delimiter = ",";
                    string[][] output = new string[][]
                    {
                new string []{"TotalNoRacks","Racks/Line","AGVs"},
                new string []{numberOfRacks,numberOfRacksPerLine,numberOfAGVs}
                    };

                    int length = output.GetLength(0);
                    StringBuilder sb = new StringBuilder();
                    for (int index = 0; index < length; index++)
                        sb.AppendLine(string.Join(delimiter, output[index]));
                    File.WriteAllText(filename, sb.ToString());
                    
                }
                else
                {
                    MessageBox.Show("You cancelled!");
                }
            }

        }

        public List<Order> OrderDetailsUpload()
        {

            List<DateTime> dates = new List<DateTime>();
            List<string> types = new List<string>();
            List<string> items = new List<string>();
            List<Order> csvorders = new List<Order>();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma-separated files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                                               //  using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                using (var fileReader = File.OpenText(path))
                using (var csv = new CsvParser(fileReader))
                {
                    

                    var firstrow = csv.Read();
                    while (true)
                    {
                        var row = csv.Read();
                        if (row == null)
                        {
                            break;
                        }
                        Order o = new Order();
                        string otime = row[0];
                        DateTime otimestamp;
                        if (DateTime.TryParse(otime, out otimestamp))
                        { o.TimeStamp = otimestamp; }
                        else o.TimeStamp = DateTime.Now;
                        o.Type = row[1];
                        o.ItemsList = new List<OrderItem>();
                        for (int i = 2; i < row.Count()-1; i++)
                        {
                            OrderItem oi = new OrderItem();
                            string[] words = row[i].Split(';');
                           
                            if(Enum.TryParse(words[1], out ProductType ptype))                 
                            oi.productItem = new Product(words[0], ptype);
                            //Console.WriteLine(oi.productItem.FullName);
                            oi.Quantity = Convert.ToInt32(words[2]);
                            o.ItemsList.Add(oi);
                        }
                        csvorders.Add(o);

                    }
                   // csvorders.ForEach(x => Console.WriteLine(x.ItemsList.Count));
                }
            }
            return csvorders;
        }

        public void SaveToFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv*)|*.csv*";
                sfd.DefaultExt = "csv";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    SaveOrdersToFile(filename);
                }
                else
                {
                    MessageBox.Show("You cancelled!");
                }
            }
        }

        public void SaveOrdersToFile(string filename)
        {
            string delimiter = ",";
            List<string> outputDates = new List<string>();
            List<string> outputTypes = new List<string>();
           // List<string> outputItemsPerOrder = new List<string>();
            string[] outputAllItems = new string[1000];
            int count = 0;

            foreach (Order o in wh.ListOrders)
            {
                outputDates.Add(o.TimeStamp.ToString());
                outputTypes.Add(o.Type.ToString());
                foreach (OrderItem oi in o.GetListOrderItems())
                {
                    //outputItemsPerOrder.Add(oi.ToString());
                    outputAllItems[count] = outputAllItems[count] + oi.productItem.Name.ToString() + ";" + oi.productItem.Type.ToString() + ";" + oi.Quantity.ToString() + delimiter;
                }
                count++;
            }

            int length = outputDates.Count;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Join(delimiter, "TimeStamp", "Type", "ItemsList"));
            for (int index = 0; index < length; index++)
            {
                sb.AppendLine(string.Join(delimiter, outputDates[index], outputTypes[index], outputAllItems[index]));
            }

            File.WriteAllText(filename, sb.ToString());

        }

        public void SaveOverview()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv*)|*.csv*";
                sfd.DefaultExt = "csv";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    string delimiter = ",";
                    List<string> logagv = new List<string>();
                    List<string> logproduct = new List<string>();
                    List<string> logquantity = new List<string>();
                    List<string> logtype = new List<string>();
                    List<string> logtime = new List<string>();
                    List<string> logstatus = new List<string>();
                    
                    foreach (AGV agv in wh.AGVList)
                    {
                        Console.WriteLine(wh.AGVList[0].events.Count);
                        foreach (LogEvent le in agv.events)
                        {
                            logagv.Add(agv.ID.ToString());
                            logproduct.Add(le.OI.productItem.FullName.ToString());
                            logquantity.Add(le.OI.Quantity.ToString());
                            logtype.Add(le.OI.Type);
                            logtime.Add(le.Time.ToString());
                            logstatus.Add(le.Status.ToString());
                      
                        }
                    }

                    int length = logagv.Count;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(string.Join(delimiter, "AGV", "Product", "Quantity", "Type", "Time", "Status"));
                    for (int i = 0; i < length; i++)
                    {
                        sb.AppendLine(string.Join(delimiter, logagv[i], logproduct[i], logquantity[i], logtype[i], logtime[i], logstatus[i]));
                    }

                    File.WriteAllText(filename, sb.ToString());
                }
            }
        }

        public List<LogEvent> UploadOverview()
        {

            List<LogEvent> events = new List<LogEvent>();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma-separated files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file

                using (var fileReader = File.OpenText(path))
                using (var csv = new CsvParser(fileReader))
                {
                    var firstrow = csv.Read();
                    while (true)
                    {
                        var row = csv.Read();
                        if (row == null)
                        {
                            break;
                        }

                        LogEvent le = new LogEvent();

                        Product ps = ProductList.possibleProducts.Find(x => x.FullName == row[1]);
                        le.OI = new OrderItem(ps, Convert.ToInt32(row[2]), row[3]);
                        le.Agv = new AGV(row[0]);
                        le.Time = DateTime.Parse(row[4]);
                        if (Enum.TryParse(row[5], out OIStatus status))
                            le.Status = status;

                        events.Add(le);

                    }
                   // events.ForEach(x => Console.WriteLine(x.Status));
                }
            }
            return events;
          
        }

    }
}
