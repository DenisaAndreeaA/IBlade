using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP
{
	 class Order
	{
        public string ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<OrderItem> OrderItems;
        public List<OrderItem> ItemsList { get; set; }
        public string Type { get; set; }
       

        public Order(string type, DateTime time, List<OrderItem> orderItems)
        {
            ID = DateTime.Now.ToString().GetHashCode().ToString("x");
            Type = type;
            TimeStamp = time;
            OrderItems = orderItems;
        }


    }
}
