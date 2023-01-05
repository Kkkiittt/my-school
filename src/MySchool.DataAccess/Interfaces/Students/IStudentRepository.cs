using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.DataAccess.Interfaces.Students
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
    }
}
