using Microsoft.EntityFrameworkCore;

using MySchool.DataAccess.DbContexts;

namespace My_School.Configurations
{
	public static class DataAccessConfiguration
	{
		public static void ConfigureDataAccess(this WebApplicationBuilder builder)
		{
			string connectionString = builder.Configuration.GetConnectionString("DataBaseConnection");
			_ = builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
			//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
		}
	}
}
