using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoSharingApplication.Models;

namespace PhotoSharingApplication.Controllers {
	[ValueReporter]
	public class PhotoController : Controller {
		private PhotoSharingContext context = new PhotoSharingContext();

		// GET: Photo
		public ActionResult Index() {
			return View(context.Photos.ToList());
		}

		public ActionResult Display(int id) {
			var photo = context.Photos.FirstOrDefault(p => p.PhotoID == id);
			if (photo == null) {
				return HttpNotFound();
			}

			return View(photo);
		}

		public ActionResult Create() {
			var photo = new Photo {
				CreatedDate = DateTime.Today
			};
			return View(photo);
		}

		[HttpPost]
		public ActionResult Create(Photo photo, HttpPostedFileBase image) {
			photo.CreatedDate = DateTime.Today;
			if (ModelState.IsValid) {
				if (image != null) {
					photo.ImageMimeType = image.ContentType;
					photo.PhotoFile = new byte[image.ContentLength];
					image.InputStream.Read(photo.PhotoFile, 0, image.ContentLength);

					context.Photos.Add(photo);
					context.SaveChanges();
					return RedirectToAction("Index");
				}
			}

			return View(photo);
		}

		public ActionResult Delete(int id) {
			var photo = context.Photos.FirstOrDefault(p => p.PhotoID == id);
			if (photo == null) {
				return HttpNotFound();
			}

			return View(photo);
		}

		[HttpPost]
		[ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id) {
			var photo = context.Photos.FirstOrDefault(p => p.PhotoID == id);
			if (photo == null) {
				return HttpNotFound();
			}

			context.Photos.Remove(photo);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		
		public FileContentResult GetImage(int id) {
			var photo = context.Photos.FirstOrDefault(p => p.PhotoID == id);
			return photo == null ? null : File(photo.PhotoFile, photo.ImageMimeType);
		}
	}
}