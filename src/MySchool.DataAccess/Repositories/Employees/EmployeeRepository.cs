using My_School.Domain.Entities.Employees;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Employees;

namespace MySchool.DataAccess.Repositories.Employees;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
	public EmployeeRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
}
