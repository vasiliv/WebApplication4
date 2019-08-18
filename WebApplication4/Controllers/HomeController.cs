using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Employee emp) {
            if (ModelState.IsValid) {
                return View();
            }
            return View("Index");
        }
    }
}