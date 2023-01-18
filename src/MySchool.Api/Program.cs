using My_School.Configurations;

using MySchool.Services.Common.Helpers;
using MySchool.Services.Common.Security;
using MySchool.Services.Interfaces.Common;
using MySchool.Services.Interfaces.Services;
using MySchool.Services.Service;
using MySchool.Services.Service.Common;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.AddMemoryCache();

builder.Services.AddScoped<IAuthManager, AuthManager>();
builder.Services.AddScoped<ICasher, Casher>();
builder.Services.AddScoped<IDtoHelper, DtoHelper>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IHasher, Hasher>();
builder.Services.AddScoped<IPaginatorService, PaginatorService>();
builder.Services.AddScoped<IConfirmationService, ConfirmationService>();
builder.Services.AddScoped<IEmailManager, EmailManager>();
builder.Services.AddScoped<IViewModelHelper, ViewModelHelper>();
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<ICharterService, CharterService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IOverallService, OverallService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.ConfigureDataAccess();
builder.ConfigureAuth();
builder.Services.ConfigureSwaggerAuthorize();

WebApplication app = builder.Build();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// Configure the HTTP request pipeline.

	_ = app.UseSwagger();
	_ = app.UseSwaggerUI();


if (app.Services.GetService<IHttpContextAccessor>() != null)
	HttpContextHelper.Accessor = app.Services.GetRequiredService<IHttpContextAccessor>();


app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
