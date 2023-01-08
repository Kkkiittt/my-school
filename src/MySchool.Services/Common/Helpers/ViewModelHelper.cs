using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Entities.Comments;
using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Employees;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.ViewModels;
using MySchool.Services.ViewModels.Articles;
using MySchool.Services.ViewModels.Charters;
using MySchool.Services.ViewModels.Comments;
using MySchool.Services.ViewModels.Employees;
using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.Common.Helpers;

public class ViewModelHelper : IViewModelHelper
{
	private IUnitOfWork _repository { get; set; }

	public ViewModelHelper(IUnitOfWork repository)
	{
		_repository = repository;
	}

	public ArticleShortViewModel ToShort(Article entity)
	{
		ArticleShortViewModel shortVM = entity;
		return shortVM;
	}
	public ArticleFullViewModel ToFull(Article entity)
	{
		ArticleFullViewModel fullVM = entity;
		fullVM.Comments = _repository.Comments.Where(x => x.ArticleId == entity.Id).Select(x => (CommentViewModel)x).ToList();
		return fullVM;
	}
	public CharterShortViewModel ToShort(Charter entity)
	{
		CharterShortViewModel charterVM = entity;
		return charterVM;
	}

	public CharterFullViewModel ToFull(Charter entity)
	{
		CharterFullViewModel charterVM = entity;
		charterVM.Student = ToShort(entity.Student);
		return charterVM;
	}

	public StudentShortViewModel ToShort(Student entity)
	{
		StudentShortViewModel studentVM = entity;
		studentVM.Charters = _repository.Charters.GetAll().Count(x => x.StudentId == entity.Id);
		return studentVM;
	}

	public StudentFullViewModel ToFull(Student entity)
	{
		StudentFullViewModel studentVM = entity;
		studentVM.Charters = _repository.Charters.Where(x => x.StudentId == entity.Id).Select(x => ToShort(x)).ToList();
		return studentVM;
	}


	public EmployeeFullViewModel ToFull(Employee entity)
	{
		EmployeeFullViewModel employeeVM = entity;
		employeeVM.Articles = _repository.Articles.Where(x => x.EmployeeId == entity.Id).Select(x => ToShort(x)).ToList();
		return employeeVM;
	}
	public CommentViewModel ToShort(Comment entity)
	{
		CommentViewModel commentVM = entity;
		return commentVM;
	}
}
