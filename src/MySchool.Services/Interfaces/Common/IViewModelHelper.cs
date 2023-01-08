using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Entities.Comments;
using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Employees;
using MySchool.DataAccess.Interfaces;
using MySchool.Services.ViewModels.Articles;
using MySchool.Services.ViewModels.Charters;
using MySchool.Services.ViewModels.Comments;
using MySchool.Services.ViewModels.Employees;
using MySchool.Services.ViewModels.Students;
using MySchool.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.Interfaces.Common
{
    public interface IViewModelHelper
    {

        public ArticleShortViewModel ToShort(Article entity);

        public ArticleFullViewModel ToFull(Article entity);

        public CharterShortViewModel ToShort(Charter entity);

        public CharterFullViewModel ToFull(Charter entity);

        public StudentShortViewModel ToShort(Student entity);

        public StudentFullViewModel ToFull(Student entity);


        public EmployeeFullViewModel ToFull(Employee entity);

        public CommentViewModel ToShort(Comment entity);

    }
}
