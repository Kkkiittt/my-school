using MySchool.Services.Dtos.Comments;
using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.Interfaces.Services;

public interface ICommentService
{
	public Task<bool> CreateAsync(CommentCreateDto dto);

	public Task<IEnumerable<CommentViewModel>> GetByArticleAsync(long articleId);

	public Task<bool> DeleteByIdAsyc(long articleId);
}
