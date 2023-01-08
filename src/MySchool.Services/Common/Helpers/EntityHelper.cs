using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.ViewModels;
using MySchool.Services.ViewModels.Articles;
using MySchool.Services.ViewModels.Charters;
using MySchool.Services.ViewModels.Comments;

namespace MySchool.Services.Common.Helpers;

public class EntityHelper
{
	private IUnitOfWork _repository { get; set; }

	public EntityHelper(IUnitOfWork repository)
	{
		_repository = repository;
	}

	public ArticleShortViewModel ToShort(Article entity)
	{
		ArticleShortViewModel shortVM = entity;
		return shortVM;
	}
	public ArticleFullViewModel ToFull(Article entity)
	{
		ArticleFullViewModel fullVM = entity;
		fullVM.Comments = _repository.Comments.Where(x => x.ArticleId == entity.Id).Select(x => (CommentViewModel)x).ToList();
		return fullVM;
	}
	public CharterShortViewModel ToShort(Charter entity)
	{
		CharterShortViewModel charterVM = entity;
		return charterVM;
	}
}
