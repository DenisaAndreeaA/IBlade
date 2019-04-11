using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP
{
    /// <summary>
    /// INBOUND - still in inbound
    /// ONRACK - when it's 
    /// PICKEDUP - while AGV brings it to the outbound
    /// OUTBOUND - when its delivered
    /// </summary>
    public enum OIStatus
    {
        INBOUND, ONRACK, PICKEDUP, OUTBOUND
            
    }

    public class OrderItem
	{
		public int ID { get; set; }
		public Product productItem { get; set; }
        public int Quantity { get; set; } //max 10
        public string Type { get; set; }
        public DateTime TimeFulfilled { get; set; }
		public DateTime PickUpTime { get; set; }
		public OIStatus Status { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(Product item, int q, string t)
        {
            productItem = item;
            Quantity = q;
            Type = t;
        }

       

	}
}
