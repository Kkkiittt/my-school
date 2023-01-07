using MySchool.Services.Dtos.Comments;
using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.Interfaces;

public interface ICommentService
{
	public Task<bool> CreateAsync(CommentCreateDto dto);

	public Task<IEnumerable<CommentViewModel>> GetByArticleAsync(long articleId);

	public Task<bool> DeleteByIdAsyc(long articleId);
}
