using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Entities.Comments;
using My_School.Domain.Entities.Employees;
using My_School.Domain.Entities.Students;

using MySchool.Services.Dtos.Articles;
using MySchool.Services.Dtos.Charters;
using MySchool.Services.Dtos.Comments;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Dtos.Students;

namespace MySchool.Services.Interfaces.Common
{
	public interface IDtoHelper
	{
		public Task<Article> ToEntity(ArticleCreateDto dto);

		public Task<Charter> ToEntity(CharterCreateDto dto);


		public Task<Employee> ToEntity(EmployeeRegisterDto dto);


		public Task<Student> ToEntity(StudentRegisterDto dto);

		public Task<Comment> ToEntity(CommentCreateDto dto);
	}
}
