using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Hire_Date { get; set; }
        public int Commission { get; set; }
        public int Job_Id { get; set; }
        public string Picture { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }
}
