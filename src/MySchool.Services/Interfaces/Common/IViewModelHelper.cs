using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Entities.Comments;
using My_School.Domain.Entities.Employees;

using MySchool.Services.ViewModels.Articles;
using MySchool.Services.ViewModels.Charters;
using MySchool.Services.ViewModels.Comments;
using MySchool.Services.ViewModels.Employees;
using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.Interfaces.Common
{
	public interface IViewModelHelper
	{

		public ArticleShortViewModel ToShort(Article entity);

		public ArticleFullViewModel ToFull(Article entity);

		public CharterShortViewModel ToShort(Charter entity);

		public CharterFullViewModel ToFull(Charter entity);

		public ViewModels.Students.StudentShortViewModel ToShort(My_School.Domain.Entities.Students.Student entity);

		public StudentFullViewModel ToFull(My_School.Domain.Entities.Students.Student entity);

		public EmployeeShortViewModel ToShort(Employee entity);

		public EmployeeFullViewModel ToFull(Employee entity);

		public CommentViewModel ToShort(Comment entity);

	}
}
