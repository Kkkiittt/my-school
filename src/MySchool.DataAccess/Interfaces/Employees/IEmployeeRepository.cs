using My_School.Domain.Entities.Articles;
using My_School.Domain.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.DataAccess.Interfaces.Employees
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {

    }
}
