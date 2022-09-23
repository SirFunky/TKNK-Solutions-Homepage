using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TKNK_Solutions_Homepage.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Our Services.";

            return View();
        }

        public ActionResult Verksamhetsutveckling()
        {
            ViewBag.Message = "Verksamhetsutveckling.";

            return View();
        }
    }
}