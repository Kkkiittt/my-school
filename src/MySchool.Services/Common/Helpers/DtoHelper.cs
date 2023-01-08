using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Models.Employees;

using MySchool.Services.Common.Interfaces;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Dtos.Charters;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;

namespace MySchool.Services.Common.Helpers;

public class DtoHelper
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
		employee.Password = _hasher.Hash(dto.Password, dto.Phone);
		return employee;
	}
}
