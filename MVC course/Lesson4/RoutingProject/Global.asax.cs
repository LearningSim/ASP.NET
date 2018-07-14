using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using RoutingProject.Areas.Admin;
using RoutingProject.Areas.Default;

namespace RoutingProject {
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			var adminArea = new AdminAreaRegistration();
			var adminContext = new AreaRegistrationContext(adminArea.AreaName, RouteTable.Routes);
			var defaultArea = new DefaultAreaRegistration();
			var defaultContext = new AreaRegistrationContext(defaultArea.AreaName, RouteTable.Routes);

			adminArea.RegisterArea(adminContext);
			defaultArea.RegisterArea(defaultContext);

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}