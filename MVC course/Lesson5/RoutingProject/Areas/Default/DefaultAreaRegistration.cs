using System.Web.Mvc;

namespace RoutingProject.Areas.Default {
	public class DefaultAreaRegistration : AreaRegistration {
		public override string AreaName {
			get {
				return "Default";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context) {
			context.MapRoute(
				"Default",
				"{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = UrlParameter.Optional },
				new[] { "RoutingProject.Areas.Default.Controllers" }
			);
		}
	}
}
