﻿using My_School.Domain.Models.Common;

namespace My_School.Domain.Entities.Students;

public class Student : BaseEntity
{
	public string Pin { get; set; } = string.Empty;

	public string Info { get; set; } = string.Empty;

	public bool Studying { get; set; } = true;
}
