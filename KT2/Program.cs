using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Product> grocery = new List<Product>();

            Console.WriteLine("All products in collection");
            grocery.Add(new Product { Name = "Whiskey ", Price = "5.30" });
            grocery.Add(new Product { Name = "New Car ", Price = "5.30" });
            grocery.Add(new Product { Name = "Bread ", Price = "5.30" });
            grocery.Add(new Product { Name = "Coffee ", Price = "5.30" });
            grocery.Add(new Product { Name = "Bananas ", Price = "5.30" });

            foreach(Product prod in grocery)
            {
                Console.WriteLine("-Product " + prod.ToString());
            }

        }
    }
}
