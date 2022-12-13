using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace TRAVIL_WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("HomePage");
        }

    }
}