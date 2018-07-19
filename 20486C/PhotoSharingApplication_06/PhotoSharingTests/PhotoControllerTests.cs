using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoSharingApplication.Models;
using PhotoSharingApplication.Controllers;
using PhotoSharingTests.Doubles;

namespace PhotoSharingTests {
	[TestClass]
	public class PhotoControllerTests {
		[TestMethod]
		public void Test_Index_Return_View() {
			var controller = new PhotoController(new FakePhotoSharingContext());
			var view = controller.Index() as ViewResult;
			Assert.AreEqual(view.ViewName, "Index");
		}

		[TestMethod]
		public void Test_PhotoGallery_Model_Type() {
			var context = new FakePhotoSharingContext {
				Photos = new[] {
					new Photo(),
					new Photo(),
					new Photo(),
					new Photo()
				}.AsQueryable()
			};
			var controller = new PhotoController(context);
			var gallery = controller._PhotoGallery() as PartialViewResult;
			Assert.AreEqual(
				gallery.Model.GetType(),
				typeof(List<Photo>)
			);
		}

		[TestMethod]
		public void Test_GetImage_Return_Type() {
			var context = new FakePhotoSharingContext {
				Photos = new[] {
					new Photo {PhotoID = 1, PhotoFile = new byte[1], ImageMimeType = "image/jpeg"},
					new Photo {PhotoID = 1, PhotoFile = new byte[1], ImageMimeType = "image/jpeg"},
					new Photo {PhotoID = 1, PhotoFile = new byte[1], ImageMimeType = "image/jpeg"},
					new Photo {PhotoID = 1, PhotoFile = new byte[1], ImageMimeType = "image/jpeg"}
				}.AsQueryable()
			};
			var controller = new PhotoController(context);
			var result = controller.GetImage(1);
			Assert.AreEqual(
				result.GetType(),
				typeof(FileContentResult)
			);
		}

		[TestMethod]
		public void Test_PhotoGallery_No_Parameter() {
			var context = new FakePhotoSharingContext {
				Photos = new[] {
					new Photo(),
					new Photo(),
					new Photo(),
					new Photo()
				}.AsQueryable()
			};
			var controller = new PhotoController(context);
			var result = controller._PhotoGallery() as PartialViewResult;
			Assert.AreEqual(
				(result.Model as IEnumerable<Photo>).Count(),
				4
			);
		}

		[TestMethod]
		public void Test_Photo_Gallery_Int_Parameter() {
			var context = new FakePhotoSharingContext {
				Photos = new[] {
					new Photo(),
					new Photo(),
					new Photo(),
					new Photo()
				}.AsQueryable()
			};
			var controller = new PhotoController(context);
			var result = controller._PhotoGallery(3) as PartialViewResult;
			Assert.AreEqual(
				(result.Model as IEnumerable<Photo>).Count(),
				3
			);
		}
	}
}