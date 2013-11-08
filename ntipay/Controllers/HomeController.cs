using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ntipay.Models;

namespace ntipay.Controllers {
    public class HomeController : Controller {
        private readonly UserContext db = new UserContext();

        public ActionResult Description() {
            return View();
        }

        public ActionResult Main() {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitEmail(User user) {
            if (ModelState.IsValid == false) {
                return View("Main");
            }
            
            db.Users.Add(user);
            db.SaveChanges();

            return View(db.Users.ToList());
        }
    }
}
