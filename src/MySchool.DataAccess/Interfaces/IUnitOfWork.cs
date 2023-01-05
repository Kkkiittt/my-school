using MySchool.DataAccess.Interfaces.Articles;
using MySchool.DataAccess.Interfaces.Charters;
using MySchool.DataAccess.Interfaces.Comments;
using MySchool.DataAccess.Interfaces.Employees;
using MySchool.DataAccess.Interfaces.Students;

namespace MySchool.DataAccess.Interfaces;

public interface IUnitOfWork
{
	public IEmployeeRepository Employees { get; set; }

	public IArticleRepository Articles { get; set; }

	public ICharterRepository Charters { get; set; }

	public IStudentRepository Students { get; set; }

	public ICommentRepository Comments { get; set; }

	public Task<int> SaveChanges();


}
