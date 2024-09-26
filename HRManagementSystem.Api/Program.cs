using HRManagementSystem.Application.Employees.Commands;
using HRManagementSystem.Infrastructure.Data;
using HRManagementSystem.Infrastructure.Departments.Interfaces;
using HRManagementSystem.Infrastructure.Departments.Repositories;
using HRManagementSystem.Infrastructure.Employees.Interfaces;
using HRManagementSystem.Infrastructure.Employees.Repositories;
using HRManagementSystem.Infrastructure.LeaveManagement.Interfaces;
using HRManagementSystem.Infrastructure.LeaveManagement.Repositories;
using HRManagementSystem.Infrastructure.PayrollManagement.Interfaces;
using HRManagementSystem.Infrastructure.PayrollManagement.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IPerformanceReviewRepository, PerformanceReviewRepository>();
builder.Services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
builder.Services.AddScoped<IPayrollRepository, PayrollRepository>();
builder.Services.AddScoped<IDepartmentSettingsRepository, DepartmentSettingsRepository>();

builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblyContaining<CreateEmployeeCommand>());

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
