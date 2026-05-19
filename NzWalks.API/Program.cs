using Microsoft.EntityFrameworkCore;
using NzWalks.API.Data;
using NzWalks.API.Repositries;
using NzWalks.API.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//injecting the DbContext into the application
builder.Services.AddDbContext<NzWalksDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NzWalksDbConnection")));

builder.Services.AddScoped<IRepositry, SqlRegionRepo>();
builder.Services.AddScoped<IWalkRepo, SqlWalkRepoClass>();
// Register AutoMapper and scan for profiles
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));


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
