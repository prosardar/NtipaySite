﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ntipay.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Description()
        {
            return View();
        }

        public ActionResult Main() {
            return View();
        }

    }
}
