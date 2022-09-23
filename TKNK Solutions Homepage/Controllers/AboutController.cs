using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TKNK_Solutions_Homepage.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to TKNK Solutions.";

            return View();
        }

        public ActionResult NiklasKarlsson()
        {
            ViewBag.Message = "Welcome to TKNK Solutions.";

            return View();
        }

        public ActionResult KiaJohanssonKarlsson()
        {
            ViewBag.Message = "Welcome to TKNK Solutions.";

            return View();
        }

        public ActionResult TommyKarlsson()
        {
            ViewBag.Message = "Welcome to TKNK Solutions.";

            return View();
        }

        public ActionResult MiaNyberg()
        {
            ViewBag.Message = "Welcome to TKNK Solutions.";

            return View();
        }

        public ActionResult KristofferKarlsson()
        {
            ViewBag.Message = "Welcome to TKNK Solutions.";

            return View();
        }
    }
}