namespace MySchool.Services.Interfaces.Common;

public interface SmsManager
{
	public Task<bool> SendCode(string number, int code);
}
