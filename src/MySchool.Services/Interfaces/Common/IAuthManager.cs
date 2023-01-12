using My_School.Domain.Entities.Employees;
using My_School.Domain.Entities.Students;

namespace MySchool.Services.Interfaces.Common
{
	public interface IAuthManager
	{
		public string GenerateToken(Student student);

		public string GenerateToken(Employee employee);
	}
}
