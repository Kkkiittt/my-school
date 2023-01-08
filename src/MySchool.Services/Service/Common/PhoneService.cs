using MySchool.DataAccess.Interfaces;
using MySchool.Services.Dtos.Common;
using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Service.Common;

public class PhoneService : IPhoneService
{
	protected ISmsManager _smsManager { get; }

	protected ICasher _casher { get; }

	protected IUnitOfWork _repository { get; }

	public PhoneService(IUnitOfWork repository, ISmsManager smsManager, ICasher casher)
	{
		_smsManager = smsManager;
		_casher = casher;
		_repository = repository;
	}

	public async Task<bool> ConfirmCode(CodeConfirmDto dto)
	{
		var code = _casher.Get(dto.Id);
		if(code == null)
			return false;
		if(code != dto.Code)
			return false;
		var entity = await _repository.Employees.FindByIdAsync(dto.Id);
		if(entity == null)
			return false;
		entity.PhoneVerified = true;
		_repository.Employees.Update(entity);
		return await _repository.SaveChanges() > 0;
	}

	public async Task<bool> SendCode(long authorId)
	{
		try
		{
			var entity = await _repository.Employees.FindByIdAsync(authorId);
			var phone = entity!.Phone;
			var rndm = new Random();
			var code = rndm.Next(100_000, 999_999);
			await _smsManager.SendCode(phone, code);
			_casher.Place(entity.Id, code, 360);
			return true;
		}
		catch
		{
			return false;
		}
	}
}
