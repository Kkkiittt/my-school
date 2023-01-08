using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels;
using MySchool.Services.ViewModels.Articles;

namespace MySchool.Services.Service;

public class ArticleService : GenericService, IArticleService
{
	public ArticleService(IUnitOfWork repository) : base(repository)
	{

	}

	public Task<bool> CreateAsync(ArticleCreateDto dto)
	{
		
	}

	public Task<bool> DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<ArticleShortViewModel>> GetAll()
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<ArticleShortViewModel>> GetByAuthor(long authorId)
	{
		throw new NotImplementedException();
	}

	public Task<ArticleFullViewModel> GetById(long id)
	{
		throw new NotImplementedException();
	}

	Task<bool> IArticleService.CreateAsync(ArticleCreateDto dto)
	{
		throw new NotImplementedException();
	}

	Task<bool> IArticleService.DeleteByIdAsync(long id)
	{
		throw new NotImplementedException();
	}

	Task<IEnumerable<ArticleShortViewModel>> IArticleService.GetAll()
	{
		throw new NotImplementedException();
	}

	Task<IEnumerable<ArticleShortViewModel>> IArticleService.GetByAuthor(long authorId)
	{
		throw new NotImplementedException();
	}

	Task<ArticleFullViewModel> IArticleService.GetById(long id)
	{
		throw new NotImplementedException();
	}
}
