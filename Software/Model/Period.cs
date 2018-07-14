using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class Period
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public DateTime Login_Time { get; set; }
        public DateTime Logout_Time { get; set; }
    }
}
