
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MySchool.Services.Attributes;
[AttributeUsage(AttributeTargets.Property)]
public class Phone : ValidationAttribute
{
	private string pattern = @"\D";
	public override bool IsValid(object? value)
	{
		var regEx = new Regex(pattern);
		var num = value!.ToString()!;
		return regEx.IsMatch(num) && num.Length == 12;
	}
}
