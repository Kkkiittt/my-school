﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using My_School.Domain.Entities.Articles;
using MySchool.DataAccess.Interfaces;
using MySchool.Services.ViewModels.Articles;
using MySchool.Services.ViewModels.Comments;
using MySchool.Services.ViewModels;

namespace MySchool.Services.Common.Helpers;

public class EntityHelper
{
	IUnitOfWork _repository { get; set; }

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
}