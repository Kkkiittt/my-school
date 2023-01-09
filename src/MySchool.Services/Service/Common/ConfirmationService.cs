using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Service.Common;

public class ConfirmationService : IConfirmationService
{
	protected IEmailManager _emailManager { get; }

	protected ICasher _casher { get; }

	protected IUnitOfWork _repository { get; }

	public ConfirmationService(IUnitOfWork repository, IEmailManager emailManager, ICasher casher)
	{
		_emailManager = emailManager;
		_casher = casher;
		_repository = repository;
	}

	public async Task<bool> ConfirmCode(CodeConfirmDto dto)
	{
		var email = (await _repository.Employees.FindByIdAsync(dto.Id)).Email;
		int? code = _casher.Get(email);
		if(code == null)
			return false;
		if(code != dto.Code)
			return false;
		My_School.Domain.Models.Employees.Employee? entity = await _repository.Employees.FindByIdAsync(dto.Id);
		if(entity == null)
			return false;
		entity.EmailVerified = true;
		_repository.Employees.Update(entity);
		return await _repository.SaveChanges() > 0;
	}

	public async Task<bool> SendCode(string email)
	{
		//try
		//{

			Random rndm = new Random();
			int code = rndm.Next(100_000, 999_999);
			_ = await _emailManager.SendCode(email, code);
			_casher.Place(email, code, 600);
			return true;
		//}
		//catch
		//{
		//	return false;
		//}
	}
}