namespace DrinksMachine4.Services
{
    public class HotDrinkFactory
    {
        public static IHotDrink Create(string drinkName)
        {
            IHotDrink hotDrink = null;

            switch (drinkName)
            {
                case "lemontea":
                    hotDrink = new LemonTea();
                    break;
                case "coffee":
                    hotDrink = new Coffee();
                    break;
                case "chocolate":
                    hotDrink = new Chocolate();
                    break;
                default:
                    hotDrink = new GenericDrink(); 
                    break;
            }

            return hotDrink;
        }
    }
}