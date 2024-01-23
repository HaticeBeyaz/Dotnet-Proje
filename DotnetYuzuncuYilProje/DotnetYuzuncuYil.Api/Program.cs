using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Core.UnitOfWork;
using DotnetYuzuncuYil.Repository;
using DotnetYuzuncuYil.Repository.Repositories;
using DotnetYuzuncuYil.Repository.UnitOfWorks;
using DotnetYuzuncuYil.Service.mapping;
using DotnetYuzuncuYil.Service.Services;
using DotnetYuzuncuYil.Service.Validations;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(mapProfile));
builder.Services.AddControllers()
    .AddFluentValidation(x =>
    {
        x.RegisterValidatorsFromAssemblyContaining<SellerDTOValidator>();
        x.RegisterValidatorsFromAssemblyContaining<CustomerDTOValidator>();
        x.RegisterValidatorsFromAssemblyContaining<CustomerProfileDTOValidator>();
    });

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

