using MyGuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGuessingGame.Controllers
{
    public class GuessingGameController : Controller
    {
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 10);   //Call-Name[string name] = new Random().Next(starting num, ending num);

            return View();
        }

        private bool GuessWasCorrect(int guess) => guess == (int)Session["Answer"];
        //private bool <BoolName>(int <name>) => <name> == (int)<RandomGenaratorName>

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GuessingGameModel model)
        {
            if (ModelState.IsValid) //TODO ask about ModelState
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }

            return View();
        }

    }
}