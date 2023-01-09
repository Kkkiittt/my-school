
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MySchool.Services.Attributes;
[AttributeUsage(AttributeTargets.Property)]
public class Email : ValidationAttribute
{
	private string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
	public override bool IsValid(object? value)
	{
		Regex regEx = new Regex(pattern);
		string num = value!.ToString()!;
		return regEx.IsMatch(num);
	}
}
