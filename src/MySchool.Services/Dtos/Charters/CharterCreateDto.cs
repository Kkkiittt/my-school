using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

using My_School.Domain.Entities.Charters;

namespace MySchool.Services.Dtos.Charters;

public class CharterCreateDto
{
	public IFormFile? Image { get; set; }
	[Required]
	public int StudentId { get; set; }
	public static implicit operator Charter(CharterCreateDto dto)
	{
		return new Charter()
		{
			StudentId = dto.StudentId,
			CreatedAt = DateTime.Now
		};
	}
}
