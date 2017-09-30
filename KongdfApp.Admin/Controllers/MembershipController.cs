using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knife.Admin.Controllers
{
    public class MembershipController : Controller
    {
        // GET: Membership
        public ActionResult Users()
        {
            return View();
        }

		public ActionResult Roles() {
			return View();
		}

		public ActionResult Modules() {
			return View();
		}

		public ActionResult Permissions() {
			return View();
		}
	}
}