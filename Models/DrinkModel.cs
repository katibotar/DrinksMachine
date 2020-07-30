using System.Collections.Generic;

namespace DrinksMachine4.Models
{
    public class DrinkModel
    {
        public string DrinkId { get; set; }

        public string DrinkLabelName { get; set; }

        public List<string> StepsToMakeDrink { get; set; }

        public DrinkModel()
        {
            StepsToMakeDrink = new List<string>();            
        }
    }
}