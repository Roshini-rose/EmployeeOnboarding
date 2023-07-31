using EmployeeOnboarding.Contracts;
using EmployeeOnboarding.Data;
using EmployeeOnboarding.Services;
using EmployeeOnboarding.Repository;
using Microsoft.EntityFrameworkCore;
using EmployeeOnboarding.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultCOnnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));


builder.Services.AddTransient<onboardstatusService>();
builder.Services.AddTransient<logindetailsService>();
builder.Services.AddTransient<EducationService>();

builder.Services.AddScoped<ILogin, AuthenticateLogin>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
