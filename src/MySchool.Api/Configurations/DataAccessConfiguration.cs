using Microsoft.EntityFrameworkCore;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces;
using MySchool.DataAccess.Repositories;

namespace My_School.Configurations;

public static class DataAccessConfiguration
{
	public static void ConfigureDataAccess(this WebApplicationBuilder builder)
	{
		string connectionString = builder.Configuration.GetConnectionString("OnlineDataBaseConnection");
		_ = builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
		_ = builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
	}
}
