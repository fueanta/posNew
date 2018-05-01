using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class Employee_Payment
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public int Amount { get; set; }
    }
}
