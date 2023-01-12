using System.Linq.Expressions;

using My_School.Domain.Common;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces;

namespace MySchool.DataAccess.Repositories;

public class GenericRepository<T> : BaseRepository<T>, IGenericRepository<T> where T : BaseEntity
{
	public GenericRepository(AppDbContext dbContext) : base(dbContext)
	{
	}

	public virtual IQueryable<T> GetAll()
	{
		return _dbSet;
	}

	public virtual IQueryable<T> Where(Expression<Func<T, bool>> expression)
	{
		return _dbSet.Where(expression);
	}

}
