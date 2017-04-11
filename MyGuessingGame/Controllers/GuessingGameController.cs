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
        
        //Post
        [HttpPost]
        public ActionResult Index(GuessingGameModel model)
        {

            return View();
        }

    }
}