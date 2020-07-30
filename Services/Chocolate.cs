using System.Collections.Generic;
using System.Diagnostics;

namespace DrinksMachine4.Services
{
    public class Chocolate : MakeTheDrink, IHotDrink
    {
        public override string AddIngredientToWater()
        {
            //Debug.WriteLine("Add drinking chocolate powder to the water");
            return "Add drinking chocolate powder to the water";
        }

        public List<string> MakeDrink()
        {
            List<string> drinkMakingSteps = new List<string>();

            drinkMakingSteps.Add(BoilSomeWater());
            drinkMakingSteps.Add(AddIngredientToWater());
            drinkMakingSteps.Add(PourDrinkIntoCup("chocolate"));          

            return drinkMakingSteps;
        }
    }
}