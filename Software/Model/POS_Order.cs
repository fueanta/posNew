using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class POS_Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Place_Time { get; set; }
        public int Employee_ID { get; set; }
        public int Bill { get; set; }
        public int Discount_Rate { get; set; }
        public int Other_Charges { get; set; }
        public int Total_Bill { get; set; }
        public string CardNumber { get; set; }

    }
}
