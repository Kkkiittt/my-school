using My_School.Domain.Entities.Charters;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Charters;

namespace MySchool.DataAccess.Repositories.Charters;

public class CharterRepository : GenericRepository<Charter>, ICharterRepository
{
	public CharterRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
}
