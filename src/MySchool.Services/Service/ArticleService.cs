using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Articles;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Exceptions;
using MySchool.Services.Common.Helpers;
using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Interfaces.Services;
using MySchool.Services.ViewModels.Articles;

namespace MySchool.Services.Service;

public class ArticleService : BasicService, IArticleService
{
	public ArticleService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager, IPaginatorService paginator) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager, paginator)
	{

	}

	public async Task<bool> CreateAsync(ArticleCreateDto dto)
	{
		//try
		//{
	
		Article article = await _dtoHelper.ToEntity(dto);
		_repository.Articles.Add(article);
		My_School.Domain.Entities.Employees.Employee? employee = await _repository.Employees.FindByIdAsync(article.EmployeeId);
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
		var employeeId = (await _repository.Articles.FindByIdAsync(id)).EmployeeId;
		if (employeeId == HttpContextHelper.UserId || HttpContextHelper.UserRole == "Admin")
		{
			_repository.Articles.Delete(id);
			 await _repository.SaveChanges();
			return true;
		}
		else
		{
			 throw new StatusCodeException(System.Net.HttpStatusCode.Forbidden,"It is not your article and you can not delete it");
		}
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
		var page = await _paginator.ToPagedAsync(_repository.Articles.GetAll().OrderByDescending(x => x.CreatedAt), @params.PageNumber, @params.PageSize);

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
		List<Article> page = await _repository.Articles.Where(x => x.EmployeeId == authorId).OrderByDescending(x => x.CreatedAt).ToListAsync();
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
		_ = await _repository.SaveChanges();
		return _viewModelHelper.ToFull(entity);
		//}
		//catch
		//{
		//	throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Not found article on this Id");
		//}
	}
}
