using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Interfaces;
using MySchool.Services.Dtos.Comments;
using MySchool.Services.Interfaces;
using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.Service;

public class CommentService : BasicService, ICommentService
{
	public CommentService(IUnitOfWork repository, IFileService filer, IHasher hasher) 
		: base(repository, filer, hasher)
	{
	}

	public async Task<bool> CreateAsync(CommentCreateDto dto)
	{
		throw new NotImplementedException();
	}

	public async Task<bool> DeleteByIdAsyc(long articleId)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<CommentViewModel>> GetByArticleAsync(long articleId)
	{
		throw new NotImplementedException();
	}
}
