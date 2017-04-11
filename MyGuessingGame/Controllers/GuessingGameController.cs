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
            return View();
        }
    }
}