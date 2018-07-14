using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Model
{
    public class Food_Ingredient
    {
        //public int Food_Id { get; set;
        public string Ingredient_Name { get; set; }
        public double Amount { get; set; }
        public int Unit_Cost { get; set; }
        public int Ingredient_Id { get; set; }

        public override string ToString()
        {
            return Ingredient_Name;
        }
    }
}
