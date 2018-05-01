using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class Rotten_Ingredient
    {
        public int Id { get; set; }
        public int Ingredient_Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date_Added { get; set; }
    }
}
