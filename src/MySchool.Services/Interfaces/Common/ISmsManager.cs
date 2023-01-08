namespace MySchool.Services.Interfaces.Common;

public interface ISmsManager
{
	public Task<bool> SendCode(string number, int code);
}
