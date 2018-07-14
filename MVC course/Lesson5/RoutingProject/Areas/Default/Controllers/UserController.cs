using System;
using System.Drawing.Imaging;
using System.Linq;
using System.Web.Mvc;
using LessonProject.Model;
using RoutingProject.Controllers;
using RoutingProject.Models.ViewModels;
using RoutingProject.Tools;

namespace RoutingProject.Areas.Default.Controllers {
	public class UserController : BaseController {
		public ActionResult Index() {
			return View(Repository.Users.ToList());
		}

		[HttpGet]
		public ActionResult Register() {
			return View(new UserView());
		}

		[HttpPost]
		public ActionResult Register(UserView userView) {
			if (userView.Captcha != Session[CaptchaImage.CaptchaValueKey].ToString()) {
				ModelState.AddModelError("Captcha", "Текст с картинки введен неверно");
			}

			var duplicate = Repository.Users.Any(u => u.Email == userView.Email);
			if (duplicate) {
				ModelState.AddModelError("Email", "Пользователь с таким email уже зарегистрирован");
			}

			if (ModelState.IsValid) {
				var user = ModelMapper.Map<UserView, User>(userView);
				Repository.CreateUser(user);
				return RedirectToAction("Index");
			}
			return View(userView);
		}

		public Action Captcha() {
			Session[CaptchaImage.CaptchaValueKey] = new Random(DateTime.Now.Millisecond).Next(1111, 9999);
			var captcha = new CaptchaImage(Session[CaptchaImage.CaptchaValueKey].ToString(), 211, 50, "Arial");

			// Change the response headers to output a JPEG image.
			Response.Clear();
			Response.ContentType = "image/jpeg";

			// Write the image to the response stream in JPEG format.
			captcha.Image.Save(Response.OutputStream, ImageFormat.Jpeg);

			// Dispose of the CAPTCHA image object.
			captcha.Dispose();
			return null;

		}
	}
}