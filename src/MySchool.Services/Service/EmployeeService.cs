using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Exceptions;
using MySchool.Services.Common.Helpers;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;
using System.Net;

namespace MySchool.Services.Service;

public class EmployeeService : BasicService, IEmployeeService
{
	public EmployeeService(IUnitOfWork repository, IFileService filer, IHasher hasher, IViewModelHelper viewModelHelper, IDtoHelper dtoHelper, IAuthManager authManager) : base(repository, filer, hasher, viewModelHelper, dtoHelper, authManager)
	{

	}

	public async Task<bool> DeleteByIdAsync(long id)
	{
		try
		{
			_repository.Employees.Delete(id);
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}
	}

	public async Task<string> LoginAsync(EmployeeLoginDto dto)
	{
		var employee = await _repository.Employees.FirstOrDefaultAsync(x => x.Phone == dto.Phone);
		if (employee is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Employee not found, Phone Number is incorrect!");

		var hashResult = _hasher.Verify(dto.Password, employee.Password, employee.Phone);
		if (hashResult)
		{
			return null;
			//return _authManager.GenerateToken(user);
		}
		else throw new StatusCodeException(HttpStatusCode.BadRequest, "Password is invalid!");
	}

	public async Task<bool> MakeAuthor(long id)
	{
		throw new NotImplementedException();
	}

	public async Task<bool> RegisterAsync(EmployeeRegisterDto dto)
	{
		try
		{
			if (_repository.Employees.GetAll().Any(x => x.Phone == dto.Phone))
			{
				throw new Exception();
			}
			var entity = await _dtoHelper.ToEntity(dto);
			 _repository.Employees.Add(entity);
			return await _repository.SaveChanges() > 0;
		}
		catch 
		{
			return false;
		}
		
	}
}
