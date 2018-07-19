using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingInitializer : DropCreateDatabaseAlways<PhotoSharingContext>
    {	
        //This gets a byte array for a file at the path specified
        //The path is relative to the route of the web site
        //It is used to seed images
        private byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }

        protected override void Seed(PhotoSharingContext context)
        {
            base.Seed(context);

			var photos = new List<Photo>
			{
				new Photo {
					Title = "Me standing on top of a mountain",
					Description = "I was very impressed with myself",
					UserName = "Fred",
					PhotoFile = getFileBytes("\\Images\\flower.jpg"),
					ImageMimeType = "image/jpeg",
					CreatedDate = DateTime.Today
				},
				new Photo {
					Title = "My New Adventure Works Bike",
					Description = "It's the bees knees!",
					UserName = "Fred",
					PhotoFile = getFileBytes("\\Images\\orchard.jpg"),
					ImageMimeType = "image/jpeg",
					CreatedDate = DateTime.Today
				},
				new Photo {
					Title = "View from the start line",
					Description = "I took this photo just before we started over my handle bars.",
					UserName = "Sue",
					PhotoFile = getFileBytes("\\Images\\path.jpg"),
					ImageMimeType = "image/jpeg",
					CreatedDate = DateTime.Today
				}
			};
			photos.ForEach(p => context.Photos.Add(p));
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment
                {
                    PhotoID = 1,
                    UserName = "NaokiSato",
                    Subject = "Test Comment",
                    Body = "This comment should appear in photo 1"
                }
            };
            comments.ForEach(c => context.Comments.Add(c));
            context.SaveChanges();
        }
    }
}