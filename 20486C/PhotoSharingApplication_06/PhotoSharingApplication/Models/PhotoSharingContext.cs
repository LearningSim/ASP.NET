using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingContext : DbContext, IPhotoSharingContext
    {
        public PhotoSharingContext() : base()
        {
            this.Database.CommandTimeout = 180;
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }

        IQueryable<Photo> IPhotoSharingContext.Photos => Photos;
	    IQueryable<Comment> IPhotoSharingContext.Comments => Comments;

		int IPhotoSharingContext.SaveChanges() => SaveChanges();

		T IPhotoSharingContext.Add<T>(T entity) {
			return Set<T>().Add(entity);
		}

		Photo IPhotoSharingContext.FindPhotoById(int id) {
			return Set<Photo>().Find(id);
		}

		Comment IPhotoSharingContext.FindCommentById(int id) {
			return Set<Comment>().Find(id);
		}

		T IPhotoSharingContext.Delete<T>(T entity) {
			return Set<T>().Remove(entity);
		}
	}
}