using Microsoft.OpenApi.Models;

namespace My_School.Configurations
{
	public static class SwagerAuthConfiguration
	{
		public static void ConfigureSwaggerAuthorize(this IServiceCollection services)
		{
			_ = services.AddSwaggerGen(c =>
			{
				c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					Name = "Authorization",
					Description =
						"JWT Authorization header using the Bearer scheme. " +
						"Example: \"Authorization: Bearer {token}\"",
					In = ParameterLocation.Header,
					Type = SecuritySchemeType.ApiKey
				});

				c.AddSecurityRequirement(new OpenApiSecurityRequirement
			{
				{
					new OpenApiSecurityScheme
					{
						Reference = new OpenApiReference
						{
							Type = ReferenceType.SecurityScheme,
							Id = "Bearer"
						}
					},
					new string[] { }
				}
			});
			});
		}
	}
}
