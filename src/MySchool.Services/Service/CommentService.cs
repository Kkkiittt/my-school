using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Comments;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.Service;

public class CommentService : BasicService, ICommentService
{
	public CommentService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager)
		: base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager)
	{
	}

	public async Task<bool> CreateAsync(CommentCreateDto dto)
	{
		try
		{
			_repository.Comments.Add(await _dtoHelper.ToEntity(dto));
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}
	}

	public async Task<bool> DeleteByIdAsyc(long articleId)
	{
		try
		{
			_repository.Comments.Delete(articleId);
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}
	}

	public async Task<IEnumerable<CommentViewModel>> GetByArticleAsync(long articleId)
	{
		try
		{
			return _repository.Comments.Where(x => x.ArticleId == articleId).OrderByDescending(x => x.CreatedAt).Select(x => _viewModelHelper.ToShort(x));
		}
		catch
		{
			return Enumerable.Empty<CommentViewModel>();
		}
	}
}
