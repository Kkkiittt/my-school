using MySchool.Services.Dtos.Charters;
using MySchool.Services.ViewModels.Charters;

namespace MySchool.Services.Interfaces;

public interface ICharterService
{
	public Task<bool> CreateAsync(CharterCreateDto dto);

	public Task<bool> DeleteByIdAsync(long id);

	public Task<IEnumerable<CharterShortViewModel>> GetAll();

	public Task<IEnumerable<CharterShortViewModel>> GetByStudent(long studentId);

	public Task<CharterFullViewModel> GetById(long id);
}
