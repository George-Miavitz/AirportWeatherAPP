using AirportWeatherAppAPI;
using AirportWeatherAppAPI.Data;
using AirportWeatherAppAPI.DiegoSPRepositories;
using AirportWeatherAppAPI.ShearerSPRepositories;
using AirportWeatherAppAPI.TaylorSPRepositories;
using AirportWeatherAppAPI.PhillipSPRepositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

//Diego builders
builder.Services.AddScoped<IAlertService, AlertService>();
builder.Services.AddScoped<IObservationService, ObservationService>();

//Taylor Builders
builder.Services.AddScoped<IGetFeedbackByUserID, GetFeedbackByUserID>();
builder.Services.AddScoped<IUserEmailUpdate, UserEmailUpdate>();

//Henry Builders
builder.Services.AddScoped<IObservationAddClass, ObservationAddClass>();
builder.Services.AddScoped<IWeatherOrgAddClass, WeatherOrgAddClass>();

//Phillip Builders
builder.Services.AddScoped<IDeleteOrgService, DeleteOrgService>();
builder.Services.AddScoped<INewUserAdd, NewUserAddService>();

builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
