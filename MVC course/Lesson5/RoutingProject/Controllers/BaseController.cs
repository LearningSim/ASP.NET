using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LessonProject.Model;
using Ninject;
using RoutingProject.Mappers;

namespace RoutingProject.Controllers
{
    public class BaseController : Controller {
		[Inject]
		public IRepository Repository { get; set; }
		[Inject]
		public IMapper ModelMapper { get; set; }
    }
}
