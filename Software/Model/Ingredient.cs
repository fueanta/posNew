using System.Collections;

namespace Software.Model
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Unit_Cost { get; set; }
        public double Amount { get; set; }        
        public int Unit_Id { get; set; }

    }
}
