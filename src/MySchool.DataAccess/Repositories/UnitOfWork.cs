using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces;
using MySchool.DataAccess.Interfaces.Articles;
using MySchool.DataAccess.Interfaces.Charters;
using MySchool.DataAccess.Interfaces.Comments;
using MySchool.DataAccess.Interfaces.Employees;
using MySchool.DataAccess.Interfaces.Students;
using MySchool.DataAccess.Repositories.Articles;
using MySchool.DataAccess.Repositories.Charters;
using MySchool.DataAccess.Repositories.Comments;
using MySchool.DataAccess.Repositories.Employees;
using MySchool.DataAccess.Repositories.Students;

namespace MySchool.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork
{
	private readonly AppDbContext _dbContext;
	public IEmployeeRepository Employees { get; }
	public IArticleRepository Articles { get; }
	public ICharterRepository Charters { get; }
	public IStudentRepository Students { get; }
	public ICommentRepository Comments { get; }

	public UnitOfWork(AppDbContext dbContext)
	{
		_dbContext = dbContext;
		Employees = new EmployeeRepository(_dbContext);
		Articles = new ArticleRepository(_dbContext);
		Charters = new CharterRepository(_dbContext);
		Students = new StudentRepository(_dbContext);
		Comments = new CommentRepository(_dbContext);
	}

	public async Task<int> SaveChanges()
	{
		return await _dbContext.SaveChangesAsync();
	}
}
