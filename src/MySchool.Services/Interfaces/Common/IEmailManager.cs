namespace MySchool.Services.Interfaces.Common;

public interface IEmailManager
{
	public Task<bool> SendCode(string number, int code);
}
