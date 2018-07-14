using System;
using System.Linq;

namespace LessonProject.Model.SqlRepository {
	public partial class SqlRepository {
		public IQueryable<User> Users {
			get {
				return Db.Users;
			}
		}

		public bool CreateUser(User instance) {
			if (instance.Id == 0) {
				instance.AddedDate = DateTime.Now;
				instance.ActivatedLink = User.GetActivateUrl();
				Db.Users.InsertOnSubmit(instance);
				Db.Users.Context.SubmitChanges();
				return true;
			}

			return false;
		}

		public bool UpdateUser(User instance) {
			User cache = Db.Users.FirstOrDefault(p => p.Id == instance.Id);
			if (cache != null) {
				cache.Birthdate = instance.Birthdate;
				cache.ActivatedDate = instance.ActivatedDate;
				cache.ActivatedLink = instance.ActivatedLink;
				cache.AddedDate = instance.AddedDate;
				cache.AvatarPath = instance.AvatarPath;
				cache.Email = instance.Email;
				cache.LastVisitDate = instance.LastVisitDate;
				cache.Password = instance.Password;
				cache.UserRoles = instance.UserRoles;
				Db.Users.Context.SubmitChanges();
				return true;
			}

			return false;
		}

		public bool RemoveUser(int idUser) {
			User instance = Db.Users.FirstOrDefault(p => p.Id == idUser);
			if (instance != null) {
				Db.Users.DeleteOnSubmit(instance);
				Db.Users.Context.SubmitChanges();
				return true;
			}

			return false;
		}
        
	}
}