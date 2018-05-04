using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Availability { get; set; }
        public int Type_Id { get; set; }
        public int Discount_Rate { get; set; }
        public int Other_Charges { get; set; }
        public int Stock_Count { get; set; }
        public string Picture { get; set; }
    }
}
