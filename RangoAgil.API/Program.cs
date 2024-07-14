using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DishesDbContext>(
    c => c.UseSqlite(builder.Configuration["ConnectionStrings:DisheDbConStr"])
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
