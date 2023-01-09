
using System.ComponentModel.DataAnnotations;



namespace MySchool.Services.Dtos.Common;

public class CodeConfirmDto
{
	[Required]
	public long Id { get; set; }
	[Required]
	public int Code { get; set; }
}
