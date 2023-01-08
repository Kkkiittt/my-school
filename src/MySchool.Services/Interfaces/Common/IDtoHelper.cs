using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Employees;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Dtos.Charters;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Dtos.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.Interfaces.Common
{
    public interface IDtoHelper
    {
        public Task<Article> ToEntity(ArticleCreateDto dto);

        public Task<Charter> ToEntity(CharterCreateDto dto);


        public Task<Employee> ToEntity(EmployeeRegisterDto dto);


        public Task<Student> ToEntity(StudentRegisterDto dto);

    }
}
