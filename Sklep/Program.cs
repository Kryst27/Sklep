using CarWorkshop.Infastructure.Presistance;
using Microsoft.EntityFrameworkCore;
using CarWorkshop.Infastructure.Extentions;

using CarWorkshop.Application.Extensions;

using CarWorkshop.Infastructure.Seeder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddApplication();


var app = builder.Build();
var scoped = app.Services.CreateScope();
var seeder =scoped.ServiceProvider.GetRequiredService<CarWorkshopSeeder>();
await seeder.Seed();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
