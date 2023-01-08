using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Employees;

namespace MySchool.Services.Interfaces.Common
{
	public interface IAuthManager
	{
		public string GenerateToken(Student student);

		public string GenerateToken(Employee employee);
	}
}
