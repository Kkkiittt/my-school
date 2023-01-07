﻿using MySchool.Services.ViewModels.Students;

namespace MySchool.Services.ViewModels.Charters;

public class CharterFullViewModel
{
	public string Image { get; set; } = string.Empty;

	public StudentShortViewModel Student { get; set; }

	public DateTime Created { get; set; }
}