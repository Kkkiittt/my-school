using System.ComponentModel.DataAnnotations;

using My_School.Domain.Entities.Students;


namespace MySchool.Services.Dtos.Students;

public class StudentRegisterDto
{
	[Required, MinLength(2), MaxLength(100)]
	public string Info { get; set; } = string.Empty;
	public static implicit operator Student(StudentRegisterDto dto)
	{
		return new Student()
		{
			Info = dto.Info,
			Acted = DateTime.MinValue,
			Studying = true
		};
	}
}
