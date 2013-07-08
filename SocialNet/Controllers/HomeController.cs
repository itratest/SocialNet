using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Так вот";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Страничка О";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Контактная страничка";

            return View();
        }
    }
}
