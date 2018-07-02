using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAM.Controllers
{
    public class SAMController : Controller
    {
        // GET: SAM
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}