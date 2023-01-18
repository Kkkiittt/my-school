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
using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Common.Helpers;

public class DtoHelper : IDtoHelper
{
	private IFileService _filer { get; set; }
	private IHasher _hasher { get; set; }

	public DtoHelper(IFileService filer, IHasher hasher)
	{
		_filer = filer;
		_hasher = hasher;
	}

	public async Task<Article> ToEntity(ArticleCreateDto dto)
	{
		Article article = dto;
		if(dto.Image != null)
		{
			article.Image = await _filer.SaveImageAsync(dto.Image);
		}
		article.CreatedAt = DateTime.Now;
		article.Views = 0;
		return article;
	}
	public async Task<Charter> ToEntity(CharterCreateDto dto)
	{
		Charter charter = dto;
		if(dto.Image != null)
		{
			charter.Image = await _filer.SaveImageAsync(dto.Image);
		}
		return charter;
	}
	public async Task<Employee> ToEntity(EmployeeRegisterDto dto)
	{
		Employee employee = dto;
		if(dto.Image != null)
		{
			employee.Image = await _filer.SaveImageAsync(dto.Image);
		}
		employee.Password = _hasher.Hash(dto.Password, dto.Email);
		return employee;
	}

	public async Task<Student> ToEntity(StudentRegisterDto dto)
	{
		Student student = dto;
		Random random = new System.Random();
		student.Pin = random.Next(100000, 999999).ToString();
		return student;
	}

	public async Task<Comment> ToEntity(CommentCreateDto dto)
	{
		Comment comment = dto;
		comment.StudentId=HttpContextHelper.UserId;
		return comment;
	}
}
