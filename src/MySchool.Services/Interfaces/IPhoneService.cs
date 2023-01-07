using MySchool.Services.Dtos.Common;

namespace MySchool.Services.Interfaces;

public interface IPhoneService
{
	public Task<bool> SendCode(long authorId);

	public Task<bool> ConfirmCode(CodeConfirmDto dto);
}
