using My_School.Domain.Entities.Employees;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Interfaces.Services;

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
		Employee? email = (await _repository.Employees.FirstOrDefaultAsync(x => x.Email == dto.Email));
		int? code = _casher.Get(email.Email);
		if(code == null)
			return false;
		if(code != dto.Code)
			return false;
		Employee? entity = await _repository.Employees.FirstOrDefaultAsync(x => x.Email == dto.Email);
		if(entity == null)
			return false;
		entity.EmailVerified = true;
		_repository.Employees.Update(entity);
		return await _repository.SaveChanges() > 0;
	}

	public async Task<long> SendCode(string email)
	{
		//try
		//{
		Employee? entity = await _repository.Employees.FirstOrDefaultAsync(x => x.Email == email);
		if(entity == null)
			throw new Exception("User Not Found");
		Random rndm = new Random();
		int code = rndm.Next(100_000, 999_999);
		_ = await _emailManager.SendCode(email, code);
		_casher.Place(email, code, 600);
		return entity.Id;
		//}
		//catch
		//{
		//	return false;
		//}
	}
}
