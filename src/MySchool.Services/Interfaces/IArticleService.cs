using MySchool.Services.Dtos.Articles;

namespace MySchool.Services.Interfaces;

public interface IArticleService
{
	public Task<bool> CtreatedAsync(ArticleCreateDto dto);

	
}
