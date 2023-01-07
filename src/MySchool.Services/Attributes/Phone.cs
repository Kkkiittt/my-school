
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MySchool.Services.Attributes;
[AttributeUsage(AttributeTargets.Property)]
public class Phone : ValidationAttribute
{
	private string pattern = @"\D";
	public override bool IsValid(object? value)
	{
		Regex regEx = new Regex(pattern);
		string num = value!.ToString()!;
		return regEx.IsMatch(num) && num.Length == 12;
	}
}
