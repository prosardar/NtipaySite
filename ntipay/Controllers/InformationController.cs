using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ntipay.Controllers {
    public class InformationController : Controller {
        //
        // GET: /Information/

        public ActionResult Technology() {
            return View();
        }

        public ActionResult Service() {
            return View();
        }

        public ActionResult Security() {
            return View();
        }

        public ActionResult About() {
            return View();
        }

    }
}
