using System.Linq;

namespace LessonProject.Model {
	public interface IRepository {
		IQueryable<Role> Roles { get; }
		IQueryable<User> Users { get; }
		IQueryable<UserRole> UserRoles { get; }

		bool CreateRole(Role instance);
		bool UpdateRole(Role instance);
		bool RemoveRole(int idRole);
		bool CreateUser(User instance);
		bool UpdateUser(User instance);
		bool RemoveUser(int idUser);
		bool CreateUserRole(UserRole instance);
		bool UpdateUserRole(UserRole instance);
		bool RemoveUserRole(int idUserRole);
	}
}