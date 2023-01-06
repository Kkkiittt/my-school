using MySchool.DataAccess.Interfaces.Articles;
using MySchool.DataAccess.Interfaces.Charters;
using MySchool.DataAccess.Interfaces.Comments;
using MySchool.DataAccess.Interfaces.Employees;
using MySchool.DataAccess.Interfaces.Students;

namespace MySchool.DataAccess.Interfaces;

public interface IUnitOfWork
{
	public IEmployeeRepository Employees { get; }

	public IArticleRepository Articles { get; }

	public ICharterRepository Charters { get; }

	public IStudentRepository Students { get; }

	public ICommentRepository Comments { get; }

	public Task<int> SaveChanges();


}
