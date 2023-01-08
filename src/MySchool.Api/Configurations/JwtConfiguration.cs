using System.Text;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace My_School.Configurations
{
	public static class JwtConfiguration
	{
		public static void ConfigureAuth(this WebApplicationBuilder builder)
		{
			IConfigurationSection _config = builder.Configuration.GetSection("Jwt");
			_ = builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
			  .AddJwtBearer(options =>
			  {
				  options.TokenValidationParameters = new TokenValidationParameters()
				  {
					  ValidateIssuer = true,
					  ValidIssuer = _config["Issuer"],
					  ValidateAudience = false,
					  ValidateLifetime = true,
					  ValidateIssuerSigningKey = true,
					  IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecretKey"]))
				  };
			  });
		}
	}
}
