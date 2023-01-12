using MySchool.Services.Common.Utils;
using MySchool.Services.Dtos.Articles;
using MySchool.Services.ViewModels.Articles;

namespace MySchool.Services.Interfaces.Services;

public interface IArticleService
{
	public Task<bool> CreateAsync(ArticleCreateDto dto);

	public Task<bool> DeleteByIdAsync(long id);

	public Task<ArticleFullViewModel> GetById(long id);

	public Task<IEnumerable<ArticleShortViewModel>> GetAll(PaginationParams @params);

	public Task<IEnumerable<ArticleShortViewModel>> GetByAuthor(long authorId);
}
