using Microsoft.AspNetCore.ResponseCompression;
using VoiceCommerceShop.AppCore.DI;
using VoiceCommerceShop.DAL.DI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration
    .AddJsonFile("appsettings.json")
    .AddJsonFile("appsettings.development.json");

builder.Services.AddDal(builder.Configuration);
builder.Services.AddAppCore();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
