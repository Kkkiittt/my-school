using System.Net;

using MySchool.DataAccess.Interfaces;
using MySchool.Services.Common.Exceptions;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;
using MySchool.Services.Interfaces.Common;

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
		My_School.Domain.Models.Employees.Employee? employee = await _repository.Employees.FirstOrDefaultAsync(x => x.Phone == dto.Phone);
		if(employee is null)
			throw new StatusCodeException(HttpStatusCode.NotFound, "Employee not found, Phone Number is incorrect!");

		bool hashResult = _hasher.Verify(dto.Password, employee.Password, employee.Phone);
		if (hashResult && employee.PhoneVerified)
		{
			return _authManager.GenerateToken(employee);
		}
		else
			throw new StatusCodeException(HttpStatusCode.BadRequest, "Password is invalid!");
	}

	public async Task<bool> MakeAuthor(long id)
	{
		try
		{
			var entity = await _repository.Employees.FindByIdAsync(id);
			entity.Role = My_School.Domain.Enums.Role.Author;
			_repository.Employees.Update(entity);
			return await _repository.SaveChanges() > 0;
		}
		catch 
		{
			throw new Exception("Command failed");			
		}
		
	}

	public async Task<bool> RegisterAsync(EmployeeRegisterDto dto)
	{
		try
		{
			if(_repository.Employees.GetAll().Any(x => x.Phone == dto.Phone))
			{
				throw new Exception();
			}
			My_School.Domain.Models.Employees.Employee entity = await _dtoHelper.ToEntity(dto);
			_repository.Employees.Add(entity);
			return await _repository.SaveChanges() > 0;
		}
		catch
		{
			return false;
		}

	}
}
