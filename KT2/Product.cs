using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Product
    {
        public string Price { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + Price;
        }
    }
}
