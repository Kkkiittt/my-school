using MySchool.Services.Dtos.Articles;
using MySchool.Services.ViewModels;
using MySchool.Services.ViewModels.Articles;

namespace MySchool.Services.Interfaces;

public interface IArticleService
{
	public Task<bool> CreateAsync(ArticleCreateDto dto);

	public Task<bool> DeleteByIdAsync(long id);

	public Task<ArticleFullViewModel> GetById(long id);

	public Task<IEnumerable<ArticleShortViewModel>> GetAll();

	public Task<IEnumerable<ArticleShortViewModel>> GetByAuthor(long authorId);


}
