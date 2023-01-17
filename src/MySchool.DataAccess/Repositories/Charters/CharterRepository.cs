using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Charters;
using My_School.Domain.Entities.Charters;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Charters;

namespace MySchool.DataAccess.Repositories.Charters;

public class CharterRepository : GenericRepository<Charter>, ICharterRepository
{
	public CharterRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
	public async override Task<Charter?> FindByIdAsync(long id)
	{
		var charter = await base.FindByIdAsync(id);
		await _dbContext.Entry(charter).Reference(x => x.Student).LoadAsync();
		return charter;
	}
	public override async Task<Charter?> FirstOrDefaultAsync(Expression<Func<Charter, bool>> expression)
	{
		var charter = await base.FirstOrDefaultAsync(expression);
		await _dbContext.Entry(charter).Reference(x => x.Student).LoadAsync();
		return charter;
	}
	public override IQueryable<Charter> GetAll()
	{
		return base.GetAll().Include(x => x.Student);
	}
	public override IQueryable<Charter> Where(Expression<Func<Charter, bool>> expression)
	{
		return base.Where(expression).Include(x => x.Student);
	}
}
