using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Charters;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Charters;

namespace MySchool.DataAccess.Repositories.Charters;

public class CharterRepository : GenericRepository<Charter>, ICharterRepository
{
	public CharterRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
	public override IQueryable<Charter> Where(Expression<Func<Charter, bool>> expression)
	{
		return base.Where(expression).Include(ch => ch.Student);
	}
	public override IQueryable<Charter> GetAll()
	{
		return base.GetAll().Include(ch => ch.Student);
	}
}
