using Ninject;

namespace LessonProject.Model.SqlRepository {
	public partial class SqlRepository : IRepository {
		[Inject]
		public LessonProejctDbDataContext Db { get; set; }
	}
}