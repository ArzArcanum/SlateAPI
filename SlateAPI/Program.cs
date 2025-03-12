using Microsoft.EntityFrameworkCore;
using SlateAPI.Models;
using DotNetEnv;

var AllowSameDomain = "_allowSameDomain";

var builder = WebApplication.CreateBuilder(args);

// Load env variables
Env.Load();
string dbConnection = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<SlateDbContext>(opt =>
    opt.UseMySQL(
        dbConnection
    )
);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSameDomain,
                      policy =>
                      {
                          policy.SetIsOriginAllowed(origin =>
                          new Uri(origin).Host == "localhost") // Allow any port on localhost
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});

builder.WebHost.UseUrls("https://localhost:7073");
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors(AllowSameDomain);

app.UseAuthorization();

app.MapControllers();

app.Run();
