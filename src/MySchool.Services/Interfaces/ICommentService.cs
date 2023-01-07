using MySchool.Services.Dtos.Comments;
using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.Interfaces;

public interface ICommentService
{
	public Task<bool> CreateAsync(CommentCreateDto dto);

	public Task<List<CommentViewModel>> GetByArticleAsync(int articleId);

	public Task<bool> DeleteByIdAsyc(int articleId);
}
