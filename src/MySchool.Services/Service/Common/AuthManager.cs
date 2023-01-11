using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using My_School.Domain.Entities.Employees;
using My_School.Domain.Entities.Students;

using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Service.Common
{
	public class AuthManager : IAuthManager
	{
		private readonly IConfiguration _config;

		public AuthManager(IConfiguration configuration)
		{
			_config = configuration.GetSection("Jwt");
		}

		public string GenerateToken(Student student)
		{
			Claim[] claims = new[]
			{
				new Claim("Id", student.Id.ToString()),
				new Claim(ClaimTypes.Role, "Student")
			};

			SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecretKey"]));
			SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

			JwtSecurityToken tokenDescriptor = new JwtSecurityToken(_config["Issuer"], _config["Audience"], claims,
				expires: DateTime.Now.AddYears(int.Parse(_config["Lifetime"])),
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

		}

		public string GenerateToken(Employee employee)
		{
			Claim[] claims = new[]
			{
				new Claim("Id", employee.Id.ToString()),
				new Claim(ClaimTypes.Role, employee.Role.ToString()),
			};

			SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecretKey"]));
			SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

			JwtSecurityToken tokenDescriptor = new JwtSecurityToken(_config["Issuer"], _config["Audience"], claims,
				expires: DateTime.Now.AddMonths(int.Parse(_config["Lifetime"])),
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
		}
	}
}
