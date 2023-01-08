using MySchool.Services.ViewModels.Common;

namespace MySchool.Services.Interfaces;

public interface IOverallService
{
	public Task<OverallViewModel> GetInfo();


}
