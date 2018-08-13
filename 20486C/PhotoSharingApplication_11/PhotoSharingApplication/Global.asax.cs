using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PhotoSharingApplication.Models;

namespace PhotoSharingApplication
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Database.SetInitializer(new PhotoSharingInitializer());
        }
    }
}
