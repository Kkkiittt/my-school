using System.ComponentModel.DataAnnotations;

namespace MySchool.Services.Attributes;
[AttributeUsage(AttributeTargets.Property)]
public class VerificationCode : ValidationAttribute
{
	public override bool IsValid(object? value)
	{
		return value is > 99999 and <= 999999;
	}
}
