using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP
{
	 public class Order
	{
        public string ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<OrderItem> ItemsList { get; set; }
        public string Type { get; set; }
        public List<string> ItemsAsString { get; set; }
       

        public Order(int counter, string type, DateTime time, List<OrderItem> items)
        {
            Random r = new Random();
            ID = DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + counter.ToString();
           
            Type = type;
            TimeStamp = time;
            ItemsList = items;
        }

        public Order()
        {
            ID = DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + 
                DateTime.Now.Millisecond.ToString();
        }
       

        public List<OrderItem> GetListOrderItems()
        {
            return ItemsList;
        }

    }
}
