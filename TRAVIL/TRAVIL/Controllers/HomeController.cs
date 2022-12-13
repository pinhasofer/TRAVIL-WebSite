using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRAVIL.Models;
using TRAVIL.Controllers;

namespace TRAVIL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowLogIn()
        {
            
            return View("LogInPage");
        }
        public ActionResult ShowRegister()
        {
            return View("RegPage");
        }
    }
}