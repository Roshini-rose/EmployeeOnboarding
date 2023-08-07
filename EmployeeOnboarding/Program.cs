using EmployeeOnboarding.Contracts;
using EmployeeOnboarding.Data;
using EmployeeOnboarding.Services;
using EmployeeOnboarding.Repository;
using Microsoft.EntityFrameworkCore;
using EmployeeOnboarding.Data.Services;
using FluentMigrator.Runner;
using System.Reflection;
using EmployeeOnboarding.Migrations;
using EmployeeOnboarding.Data.Services;

var builder = WebApplication.CreateBuilder(args);
//Cors Policy
builder.Services.AddCors(options =>
                options.AddPolicy(
                    "CorsPolicy",
                    builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
                    ));

// Add services to the container.
//
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultCOnnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));

//builder.Services.AddTransient<onboardstatusService>();
//builder.Services.AddTransient<logindetailsService>();
//builder.Services.AddTransient<EducationService>();
builder.Services.AddTransient<WorkExperienceService>();
builder.Services.AddTransient<IAdminRepository, AdminRepository>();
//builder.Services.AddScoped<ILogin, AuthenticateLogin>();
//builder.Services.AddTransient<logindetailsService>();
builder.Services.AddTransient<EducationService>();
//builder.Services.AddTransient<WorkExperienceService>();
//builder.Services.AddTransient<IAdminRepository, AdminRepository>();
//builder.Services.AddScoped<ILogin, AuthenticateLogin>();
builder.Services.AddLogging(c => c.AddFluentMigratorConsole())
    .AddFluentMigratorCore()
    .ConfigureRunner(c => c.AddPostgres().WithGlobalConnectionString("DefaultConnection")
    .ScanIn(typeof(AddLogin_202308021630).Assembly).For.Migrations().For.EmbeddedResources());

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

using (var scope = app.Services.CreateScope())
{
    {
        var db=scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
        db.MigrateUp();
    }
}

app.UseAuthorization();

app.MapControllers();

app.Run();
