using DrinksMachine4.Models;
using DrinksMachine4.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace DrinksMachine4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // hard coding some drinks
            List<DrinkModel> drinks = new List<DrinkModel> {
                    new DrinkModel { DrinkId = "lemontea", DrinkLabelName = "Lemon Tea"},
                    new DrinkModel { DrinkId = "coffee", DrinkLabelName = "Coffee"},
                    new DrinkModel { DrinkId = "chocolate", DrinkLabelName = "Chocolate" },
                    new DrinkModel { DrinkId = "na", DrinkLabelName = "N/A" },
                    new DrinkModel { DrinkId = "na", DrinkLabelName = "N/A" },
                };          

            TempData["datacontainer"] = drinks;

            return View(drinks);
        }

        public ActionResult GetDrink(string id)
        {
            List<DrinkModel> drinks = (List<DrinkModel>)TempData["datacontainer"];
            TempData.Keep("datacontainer");

            //find the selected drink  for the id in 'drinks' 
            DrinkModel drink = drinks.First(x => x.DrinkId == id);
            drink.StepsToMakeDrink = new List<string>();

            //get the steps needed to make the drink
            IHotDrink theDrink = HotDrinkFactory.Create(id);
            List<string> stepsToMakeDrink = theDrink.MakeDrink();

            drink.StepsToMakeDrink.AddRange(stepsToMakeDrink);        

            return View(drink);
        }
    }
}