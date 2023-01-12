using System.Linq.Expressions;

using My_School.Domain.Common;

namespace MySchool.DataAccess.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
	public Task<T?> FindByIdAsync(long id);

	public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);

	public void Add(T entity);

	public void Delete(long id);

	public void Update(T entity);
}
