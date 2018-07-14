using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle;
using Ninject;

namespace Project.Controllers {
	public class HomeController : Controller {
		[Inject]
		public IWeapon Weapon { get; set; }
		//
		// GET: /Home/

		public ActionResult Index() {
			return View(Weapon);
		}
	}
}