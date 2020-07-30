using System.Collections.Generic;

namespace DrinksMachine4.Services
{
    public class GenericDrink : IHotDrink
    {
        public List<string> MakeDrink()
        {
            List<string> drinkMakingSteps = new List<string>();
            drinkMakingSteps.Add("This drink is not available");   
            return drinkMakingSteps;
        }
    }
}