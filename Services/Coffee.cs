using System.Collections.Generic;
using System.Diagnostics;

namespace DrinksMachine4.Services
{
    public class Coffee : MakeTheDrink, IHotDrink
    {
        public override string AddIngredientToWater()
        {
            //Debug.WriteLine("Brew the coffee grounds");
            return "Brew the coffee grounds";
        }
        public override string AddExtras()
        {
            //Debug.WriteLine("Add sugar and milk");
            return "Add sugar and milk";
        }
        public List<string> MakeDrink()
        {
            List<string> drinkMakingSteps = new List<string>();

            drinkMakingSteps.Add(BoilSomeWater());
            drinkMakingSteps.Add(AddIngredientToWater());
            drinkMakingSteps.Add(PourDrinkIntoCup("coffee"));
            drinkMakingSteps.Add(AddExtras());

            return drinkMakingSteps;
        }
    }
}