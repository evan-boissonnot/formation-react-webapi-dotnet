using SuiviDrones.Api.Application;
using SuiviDrones.Api.DataLayers;
using SuiviDrones.API.Controllers;
using SuiviDrones.API.Interfaces;

// HealthStatusDroneController controller = new HealthStatusDroneController(new HealthStatusDroneRepository());    



var builder = WebApplication.CreateBuilder(args);

// builder.Configuration

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDroneDataLayer, SqlServerDroneDataLayer>();
//builder.Services.AddScoped<IDroneDataLayer, EfDroneDataLayer>();

builder.Services.AddScoped<IHealthStatusDroneRepository, HealthStatusDroneRepository>();
builder.Services.AddScoped<IDroneRepository, DatabaseDroneRepository>();

//if (builder.Environment.IsDevelopment())
//{
//    builder.Services.AddScoped<IDroneRepository, InMemoryDroneRepository>();
//}

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
