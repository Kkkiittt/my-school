using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using My_School.Domain.Common;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces;

namespace MySchool.DataAccess.Repositories;

public class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
	protected AppDbContext _dbContext { get; set; }
	protected DbSet<T> _dbSet { get;  }

	public BaseRepository(AppDbContext dbContext)
	{
		_dbContext = dbContext;
		_dbSet = dbContext.Set<T>();
	}

	public void Add(T entity)
	{
		_ = _dbSet.Add(entity);
	}

	public void Delete(long id)
	{
		T? entity = _dbSet.Find(id);
		if(entity is not null)
			_ = _dbSet.Remove(entity);
	}

	public virtual async Task<T?> FindByIdAsync(long id)
	{
		return await _dbSet.FindAsync(id);
	}

	public virtual async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
	{
		return await _dbSet.FirstOrDefaultAsync(expression);
	}

	public void Update(T entity)
	{
		_ = _dbSet.Update(entity);
	}
}
