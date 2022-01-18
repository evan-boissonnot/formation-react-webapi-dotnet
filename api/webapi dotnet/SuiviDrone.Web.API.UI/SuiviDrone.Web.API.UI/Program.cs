using SuiviDrones.API;
using SuiviDrones.API.Repositories;
using SuiviDrones.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using SuiviDrones.Interfaces.Services;
using SuiviDrones.API.Infrastructures;
using SuiviDrones.API.Models;
using SuiviDrone.Web.API.UI.ExtensionMethods;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<SuiviDronesContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SuiviDrones"));
});
builder.Services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<SuiviDronesContext>()
                .AddDefaultTokenProviders();

builder.Services.Configure<SecurityOption>(builder.Configuration.GetSection("Jwt"));

builder.Services.AddScoped<ITokenGenerator, JwtTokenGenerator>();
builder.Services.AddScoped<IDroneRepository, DroneRepository>();
builder.Services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCustomAuthentication(builder.Configuration);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// https://docs.microsoft.com/fr-fr/dotnet/architecture/porting-existing-aspnet-apps/authentication-differences
app.UseAuthentication();
// https://taithienbo.medium.com/why-you-need-to-register-authentication-middleware-even-if-your-asp-net-57b2cfe58147
app.UseAuthorization();

app.MapControllers();

app.Run();
