using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoSharingApplication;
using PhotoSharingTests.Doubles;

namespace PhotoSharingTests {
	[TestClass]
	public class RoutingTests {
		[TestMethod]
		public void Test_Default_Route_ControllerOnly() {
			var context = new FakeHttpContextForRouting(requestUrl: "~/ControllerName");
			var routes = new RouteCollection();
			RouteConfig.RegisterRoutes(routes);
			var routeData = routes.GetRouteData(context);

			Assert.IsNotNull(routeData);
			Assert.AreEqual(routeData.Values["controller"], "ControllerName");
			Assert.AreEqual(routeData.Values["action"], "Index");
			Assert.AreEqual(routeData.Values["id"], UrlParameter.Optional);
		}

		[TestMethod]
		public void Test_Photo_Route_With_PhotoID() {
			var context = new FakeHttpContextForRouting(requestUrl: "~/photo/2");
			var routes = new RouteCollection();
			RouteConfig.RegisterRoutes(routes);
			var routeData = routes.GetRouteData(context);

			Assert.IsNotNull(routeData);
			Assert.AreEqual(routeData.Values["controller"], "Photo");
			Assert.AreEqual(routeData.Values["action"], "Display");
			Assert.AreEqual(routeData.Values["id"], "2");
		}

		[TestMethod]
		public void Test_Photo_Title_Route() {
			var context = new FakeHttpContextForRouting(requestUrl: "~/photo/title/my%20title");
			var routes = new RouteCollection();
			RouteConfig.RegisterRoutes(routes);
			var routeData = routes.GetRouteData(context);

			Assert.IsNotNull(routeData);
			Assert.AreEqual(routeData.Values["controller"], "Photo");
			Assert.AreEqual(routeData.Values["action"], "DisplayByTitle");
			Assert.AreEqual(routeData.Values["title"], "my%20title");
		}
	}
}
