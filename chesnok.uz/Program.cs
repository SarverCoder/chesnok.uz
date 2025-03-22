using chesnok.Application.Repository;
using chesnok.Application.Repository.Interfaces;
using chesnok.Application.Service;
using chesnok.DataAccess;
using chesnok.uz.Extensions;
using chesnok.uz.Middlewares;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSerilog((serviceProvider, loggerConfiguration) =>
{
    loggerConfiguration
        .ReadFrom
        .Configuration(builder.Configuration);
});



builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
        .UseSnakeCaseNamingConvention();
});

builder.Services.AddScoped<IFoodItemRepository, FoodItemRepository>();
builder.Services.AddScoped<IFoodItemService, FoodItemService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandling();

app.UseRequestLogging();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

// app.UseMiddleware<ImageResizeMiddleware>();


app.MapControllers();

app.Run();
