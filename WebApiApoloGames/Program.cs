using Microsoft.EntityFrameworkCore;
using WebApiApoloGames.Repository;
using WebApiApoloGames.Repository.Models;
using WebApiApoloGames.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(typeof(MappingProfileServices));

// Add services to the container.
builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddDbContext<ApoloGamesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddServices();
builder.Services.AddRepositoryServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
