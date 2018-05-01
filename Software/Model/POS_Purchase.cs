using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class POS_Purchase
    {
        public int Id { get; set; }        
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public int Employee_Id { get; set; }
        public int Supplier_Id { get; set; }
        public int Cost { get; set; }
        public int Discount_Rate { get; set; }
        public int Total_Cost { get; set; }
        

    }
}
