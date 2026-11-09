using Infrastructure;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
{

    string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    options.UseNpgsql(
        connectionString,
        npgsql => npgsql.ConfigureEnums()
    );

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();