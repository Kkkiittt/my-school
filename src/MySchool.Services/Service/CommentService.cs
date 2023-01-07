using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Comments;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.Service;

public class CommentService : BasicService, ICommentService
{
	public CommentService(IUnitOfWork repository) : base(repository)
	{
	}

	public Task<bool> CreateAsync(CommentCreateDto dto)
	{
		throw new NotImplementedException();
	}

	public Task<bool> DeleteByIdAsyc(long articleId)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<CommentViewModel>> GetByArticleAsync(long articleId)
	{
		throw new NotImplementedException();
	}
}
