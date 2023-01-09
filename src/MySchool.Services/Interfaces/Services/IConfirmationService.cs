using MySchool.Services.Dtos.Common;

namespace MySchool.Services.Interfaces.Common;

public interface IConfirmationService
{
	public Task<bool> SendCode(long authorId);

	public Task<bool> ConfirmCode(CodeConfirmDto dto);
}
