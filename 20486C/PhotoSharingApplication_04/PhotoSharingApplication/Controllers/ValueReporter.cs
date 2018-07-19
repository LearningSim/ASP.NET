using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace PhotoSharingApplication.Controllers {
	public class ValueReporter : ActionFilterAttribute {
		private void logValues(RouteData routeData) {
			var controller = routeData.Values["controller"];
			var action = routeData.Values["action"];
			var msg = $"Controller: {controller}, Action: {action}";
			Debug.WriteLine(msg, "Action Values");

			foreach (var val in routeData.Values) {
				Debug.WriteLine($">> key: {val.Key}, value: {val.Value}");
			}
		}

		public override void OnActionExecuting(ActionExecutingContext filterContext) {
			logValues(filterContext.RouteData);
		}
	}
}