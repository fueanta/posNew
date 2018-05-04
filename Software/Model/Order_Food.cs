using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class Order_Food
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Unit_Price { get; set; }
        public int Food_Id { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
