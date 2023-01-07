
using System.ComponentModel.DataAnnotations;


namespace MySchool.Services.Dtos.Commons;

public class PhoneConfirmDto
{
	[Required]
	public int Id { get; set; }
	[Required]
	public int Code { get; set; }
}
