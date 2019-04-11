using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP
{
    public static class ProductList
    {
        public static List<Product> possibleProducts;
        static ProductList()
        {
            possibleProducts = new List<Product>
            {
                new Product("Amira", ProductType.Chair),
                new Product("Denisa", ProductType.Table),
                new Product("Emese", ProductType.Bed),
                new Product("Iana", ProductType.Cabinet),
                new Product("Bogdan", ProductType.Chair),
                new Product("Leo", ProductType.Table)
            };
        }
        
    }

    public enum ProductType
    {
        None, Chair, Table, Bed, Cabinet
    }

	public class Product
	{
		public int ID { get; set; }
		public int Size { get; set; }
		public int Weight { get; set; }
		public ProductType Type { get; set; }
		public string Name { get; set; }
		public string RackID { get; set; }
		public string LineID { get; set; }
        public string FullName
        {
            get {
                return Name + " (" + Type + ")";
            } 
            //set
            //{
            //    string[] s = value.Split('(');
            //    Name = s[0];
            //    string[] st = s[2].Split(')');
            //    if (Enum.TryParse(st[0], out ProductType ptype))
            //        Type = ptype;
            //    Console.WriteLine(Name, ptype);
            //}
        }

        public Product(string name, ProductType pt)
        {
            Name = name;
            Type = pt;
        }







	}
}
