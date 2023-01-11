﻿using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Articles;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.ViewModels;
using MySchool.Services.ViewModels.Articles;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MySchool.Services.Service;

public class ArticleService : BasicService, IArticleService
{
	public ArticleService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager)
	{

	}

	public async Task<bool> CreateAsync(ArticleCreateDto dto)
	{
		//try
		//{
		Article article = await _dtoHelper.ToEntity(dto);
		_repository.Articles.Add(article);
		var employee = await _repository.Employees.FindByIdAsync(article.EmployeeId);
		employee.Acted = DateTime.Now;
		_repository.Employees.Update(employee);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		//try
		//{
		_repository.Articles.Delete(id);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}

	public async Task<IEnumerable<ArticleShortViewModel>> GetAll(PaginationParams @params)
	{
		//try
		//{
		var page = await _repository.Articles.GetAll().OrderByDescending(x => x.CreatedAt).Skip((@params.PageNumber - 1) * @params.PageSize).Take(@params.PageSize)
					 .ToListAsync();

		return page.Select(x => _viewModelHelper.ToShort(x));
		//}
		//catch
		//{
		//	return Enumerable.Empty<ArticleShortViewModel>();
		//}
	}

	public async Task<IEnumerable<ArticleShortViewModel>> GetByAuthor(long authorId)
	{
		//try
		//{
		var page = await _repository.Articles.Where(x => x.EmployeeId == authorId).OrderByDescending(x => x.CreatedAt).ToListAsync();
		return page.Select(x => _viewModelHelper.ToShort(x));
		//}
		//catch
		//{
		//	return Enumerable.Empty<ArticleShortViewModel>();
		//}
	}

	public async Task<ArticleFullViewModel> GetById(long id)
	{
		//try
		//{
		Article? entity = await _repository.Articles.FindByIdAsync(id);
		if(entity == null)
			throw new Exception("Not found");
		entity.Views += 1;
		_repository.Articles.Update(entity);
		await _repository.SaveChanges();
		return _viewModelHelper.ToFull(entity);
		//}
		//catch
		//{
		//	throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Not found article on this Id");
		//}
	}
}
