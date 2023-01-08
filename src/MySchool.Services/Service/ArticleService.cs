using My_School.Domain.Entities.Articles;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.ViewModels;
using MySchool.Services.ViewModels.Articles;

namespace MySchool.Services.Service;

public class ArticleService : BasicService, IArticleService
{
	public ArticleService(IUnitOfWork repository, IFileService filer, IHasher hasher)
		: base(repository, filer, hasher)
	{

	}

	public async Task<bool> CreateAsync(ArticleCreateDto dto)
	{
		try
		{
			Article article = dto;
			if(dto.Image != null)
			{
				article.Image = await _filer.SaveImageAsync(dto.Image);
			}
			article.CreatedAt = DateTime.Now;
			article.Views = 0;
			_repository.Articles.Add(article);
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}
	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		try
		{
			_repository.Articles.Delete(id);
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}
	}

	public async Task<IEnumerable<ArticleShortViewModel>> GetAll()
	{
		try
		{
			throw new NotImplementedException();
		}
		catch
		{
			return Enumerable.Empty<ArticleShortViewModel>();
		}
	}

	public async Task<IEnumerable<ArticleShortViewModel>> GetByAuthor(long authorId)
	{
		throw new NotImplementedException();
	}

	public async Task<ArticleFullViewModel> GetById(long id)
	{
		throw new NotImplementedException();
	}
}
