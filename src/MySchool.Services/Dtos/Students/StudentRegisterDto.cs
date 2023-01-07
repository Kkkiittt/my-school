using MySchool.Services.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.Dtos.Students;

public class StudentRegisterDto 
{
	[Required, MinLength(2), MaxLength(100)]
	public string Info { get; set; } = string.Empty;

	[Required, VerificationCode]
	public int Pin { get; set; }
}
