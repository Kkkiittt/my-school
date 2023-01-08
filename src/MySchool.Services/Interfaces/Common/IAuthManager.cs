using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.Interfaces.Common
{
	public interface IAuthManager
	{
		public string GenerateToken(Student student);

		public string GenerateToken(Employee employee);
	}
}
