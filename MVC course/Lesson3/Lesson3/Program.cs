using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonProject.Model;

namespace Lesson3 {
	class Program {
		static void Main(string[] args) {
			var context = new LessonProejctDbDataContext();

			Console.WriteLine("roles");
			foreach (var role in context.Roles) {
				Console.WriteLine("{0} {1} {2}", role.Id, role.Code, role.Name);
			}

			Console.WriteLine("users");
			foreach (var user in context.Users) {
				Console.WriteLine("{0} {1} {2}", user.Id, user.Email, user.Password);
			}

			Console.ReadLine();
		}
	}
}