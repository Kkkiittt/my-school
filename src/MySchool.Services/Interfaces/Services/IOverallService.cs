using MySchool.Services.ViewModels.Common;

namespace MySchool.Services.Interfaces.Services;

public interface IOverallService
{
	public Task<OverallViewModel> GetInfo();


}
