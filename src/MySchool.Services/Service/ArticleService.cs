using MySchool.Services.Dtos.Articles;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels;
using MySchool.Services.ViewModels.Articles;

namespace MySchool.Services.Service;

public class ArticleService : IArticleService
{
	public Task<bool> CreateAsync(ArticleCreateDto dto)
	{
		throw new NotImplementedException();
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
}
