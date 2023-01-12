using System.Linq.Expressions;

using My_School.Domain.Common;

namespace MySchool.DataAccess.Interfaces;

public interface IGenericRepository<T> : IRepository<T> where T : BaseEntity
{
	public IQueryable<T> GetAll();

	public IQueryable<T> Where(Expression<Func<T, bool>> expression);
}
