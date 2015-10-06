using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTestClient1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. Client 2";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. - Client 2 ";

            return View();
        }
    }
}