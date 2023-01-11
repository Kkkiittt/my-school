
using System.ComponentModel.DataAnnotations;



namespace MySchool.Services.Dtos.Common;

public class CodeConfirmDto
{
	[Required]
	public string Email { get; set; }
	[Required]
	public int Code { get; set; }
}
