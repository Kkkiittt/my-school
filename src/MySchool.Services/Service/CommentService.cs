using Microsoft.EntityFrameworkCore;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Helpers;
using MySchool.Services.Dtos.Comments;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Interfaces.Services;
using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.Service;

public class CommentService : BasicService, ICommentService
{
	public CommentService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager, IPaginatorService paginator)
		: base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager, paginator)
	{
	}


	public async Task<bool> CreateAsync(CommentCreateDto dto)
	{
		//try
		//{
		_repository.Comments.Add(await _dtoHelper.ToEntity(dto));
		My_School.Domain.Entities.Students.Student? student = await _repository.Students.FindByIdAsync(HttpContextHelper.UserId);
		student.Acted = DateTime.Now;
		_repository.Students.Update(student);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}

	public async Task<bool> DeleteByIdAsyc(long articleId)
	{
		//try
		//{
		_repository.Comments.Delete(articleId);
		return await _repository.SaveChanges() > 0;
		//}
		//catch
		//{
		//	return false;
		//}
	}

	public async Task<IEnumerable<CommentViewModel>> GetByArticleAsync(long articleId)
	{
		//try
		//{
		List<My_School.Domain.Entities.Comments.Comment> page = await _repository.Comments.Where(x => x.ArticleId == articleId).OrderByDescending(x => x.CreatedAt).ToListAsync();
		return page.Select(x => _viewModelHelper.ToShort(x));
		//}
		//catch
		//{
		//	return Enumerable.Empty<CommentViewModel>();
		//}
	}
}
