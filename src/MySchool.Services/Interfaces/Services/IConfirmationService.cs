using MySchool.Services.Dtos.Common;

namespace MySchool.Services.Interfaces.Common;

public interface IConfirmationService
{
	public Task<long> SendCode(string email);

	public Task<bool> ConfirmCode(CodeConfirmDto dto);
}
