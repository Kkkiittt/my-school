using System.ComponentModel.DataAnnotations;

using MySchool.Services.Attributes;

namespace MySchool.Services.Dtos.Students;

public class StudentRegisterDto
{
	[Required, MinLength(2), MaxLength(100)]
	public string Info { get; set; } = string.Empty;

	[Required, VerificationCode]
	public int Pin { get; set; }
}
