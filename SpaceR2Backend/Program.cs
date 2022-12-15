using Hangfire;
using Hangfire.Storage.SQLite;
using Microsoft.EntityFrameworkCore;
using SpaceR2Backend.DAOs;
using SpaceR2Backend.database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddHangfire(configuration => configuration
        .UseSimpleAssemblyNameTypeSerializer()
        .UseRecommendedSerializerSettings()
        .UseSQLiteStorage());
builder.Services.AddHangfireServer();

//todo: fix best practices
builder.Services.AddScoped<PoDDAO, PoDDAO>();
builder.Services.AddScoped<PeopleDAO, PeopleDAO>();
builder.Services.AddScoped<LaunchDAO, LaunchDAO>();
builder.Services.AddScoped<HttpClient, HttpClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHangfireDashboard();

app.MapControllers();
{
    using (var context = new Context())
    {
        context.Database.Migrate();
    }
}

app.Run();
