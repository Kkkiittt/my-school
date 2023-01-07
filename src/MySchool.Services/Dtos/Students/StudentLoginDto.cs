
using System.ComponentModel.DataAnnotations;


namespace MySchool.Services.Dtos.Students;

public class StudentLoginDto
{
	[Required]
	public int Id { get; set; }
	[Required]
	public int Pin { get; set; }

}
