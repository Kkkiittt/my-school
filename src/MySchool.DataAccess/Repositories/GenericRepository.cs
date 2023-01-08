using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using My_School.Domain.Models.Common;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces;

namespace MySchool.DataAccess.Repositories;

public class GenericRepository<T> : BaseRepository<T>, IGenericRepository<T> where T : BaseEntity
{
	public GenericRepository(AppDbContext dbContext) : base(dbContext)
	{
	}

	public IQueryable<T> GetAll()
	{
		return _dbSet.AsNoTracking();
	}

	public IQueryable<T> Where(Expression<Func<T, bool>> expression)
	{
		return _dbSet.Where(expression).AsNoTracking();
	}

}
