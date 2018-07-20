using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoSharingApplication.Models;

namespace PhotoSharingApplication.Controllers
{
    public class CommentController : Controller
    {
        private IPhotoSharingContext context;

        //Constructors
        public CommentController()
        {
            context = new PhotoSharingContext();
        }

        public CommentController(IPhotoSharingContext Context)
        {
            context = Context;
        }

        [ChildActionOnly]
        public PartialViewResult _CommentsForPhoto(int photoId)
        {
            ViewBag.PhotoId = photoId;
            var comments = context.Comments.Where(c => c.PhotoID == photoId);
            return PartialView(comments.ToList());
        }

        [HttpPost]
        public PartialViewResult _CommentsForPhoto(Comment comment, int photoId)
        {
            context.Add(comment);
            context.SaveChanges();

            ViewBag.PhotoId = photoId;
            var comments = context.Comments.Where(c => c.PhotoID == photoId);
            return PartialView(comments.ToList());
        }
        
        public PartialViewResult _Create(int photoId)
        {
            ViewBag.PhotoId = photoId;
            var comment = new Comment
            {
                PhotoID = photoId
            };
            return PartialView("_CreateAComment");
        }

        //
        // GET: /Comment/Delete/5
        public ActionResult Delete(int id = 0)
        {
            Comment comment = context.FindCommentById(id);
            ViewBag.PhotoID = comment.PhotoID;
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // POST: /Comment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Comment comment = context.FindCommentById(id);
            context.Delete<Comment>(comment);
            context.SaveChanges();
            return RedirectToAction("Display", "Photo", new { id = comment.PhotoID });
        }

    }
}
