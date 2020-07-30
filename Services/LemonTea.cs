using System.Collections.Generic;
using System.Diagnostics;

namespace DrinksMachine4.Services
{
    public class LemonTea : MakeTheDrink, IHotDrink
    {
        public override string AddIngredientToWater()
        {
            // Debug.WriteLine("Steep the water in the tea");

            return "Steep the water in the tea";
        }
        public override string AddExtras()
        {
            //Debug.WriteLine("Add lemon");
            return "Add lemon";
        }
        public List<string> MakeDrink()
        {
            List<string> drinkMakingSteps = new List<string>();

            drinkMakingSteps.Add(BoilSomeWater());
            drinkMakingSteps.Add(AddIngredientToWater());
            drinkMakingSteps.Add(PourDrinkIntoCup("tea"));
            drinkMakingSteps.Add(AddExtras());

            return drinkMakingSteps;
        }
    }
}