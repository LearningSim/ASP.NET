using System.Linq;
using System.Web.Mvc;
using RoutingProject.Controllers;

namespace RoutingProject.Areas.Default.Controllers {
	public class UserController : BaseController {
		public ActionResult Index() {
			return View(Repository.Users.ToList());
		}
	}
}