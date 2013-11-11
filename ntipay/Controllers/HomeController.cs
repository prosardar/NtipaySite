using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using NLog;
using ntipay.Models;

namespace ntipay.Controllers {
    [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
    public class HomeController : Controller {
        private readonly UserContext db = new UserContext();

        public HomeController() {

        }

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
            user.UserId = null;
            db.Users.Add(user);

            try {
                db.SaveChanges();
            }
            catch (Exception e) {
                ModelState.AddModelError("Email", e);
                return View("Main");
            }
            return View(user);
        }

        public ActionResult IsEmail_Available(string email) {
            var result = db.Users.Any(u => u.Email == email) == false;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
