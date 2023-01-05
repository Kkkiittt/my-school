using My_School.Domain.Entities.Students;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Students;

namespace MySchool.DataAccess.Repositories.Students;

public class StudentRepository : GenericRepository<Student>, IStudentRepository
{
	public StudentRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
}
