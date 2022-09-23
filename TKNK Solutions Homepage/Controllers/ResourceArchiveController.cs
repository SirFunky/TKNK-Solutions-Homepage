using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TKNK_Solutions_Homepage.Controllers
{
    public class ResourceArchiveController : Controller
    {
        // GET: ResourceArchive
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ResourceArchive()
        {
            ViewBag.Message = "Our Services.";

            return View();
        }
    }
}