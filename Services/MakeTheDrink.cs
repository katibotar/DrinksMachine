using System.Diagnostics;

namespace DrinksMachine4.Services
{
    public abstract class MakeTheDrink
    {
        public virtual string BoilSomeWater()
        {
            //Debug.WriteLine("Boil some water");
            return "Boil some water";
        }
        public abstract string AddIngredientToWater();

        public virtual string PourDrinkIntoCup(string theDrink)
        {
            //Debug.WriteLine("Pour " + theDrink + " in the cup");
            return "Pour " + theDrink + " in the cup";
        }

        public virtual string AddExtras() {
            return "";
        }
    }
}