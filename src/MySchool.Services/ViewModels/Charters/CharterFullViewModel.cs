﻿using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Models.Common;

using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.ViewModels.Charters;

public class CharterFullViewModel : BaseEntity
{
	public string Image { get; set; } = string.Empty;

	public StudentShortViewModel Student { get; set; }

	public DateTime Created { get; set; }

	public static implicit operator CharterFullViewModel(Charter entity)
	{
		return new CharterFullViewModel()
		{
			Image = entity.Image,
			Created = entity.CreatedAt
		};
	}
}
