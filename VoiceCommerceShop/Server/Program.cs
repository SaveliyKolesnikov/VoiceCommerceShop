using System.Reflection;
using VoiceCommerceShop.AppCore.DI;
using VoiceCommerceShop.CognitiveServices.Speech;
using VoiceCommerceShop.DAL.DI;
using VoiceCommerceShop.Shared;

var builder = WebApplication.CreateBuilder(args);

var serviceCollection = builder.Services;
var configuration = builder.Configuration;

// Add services to the container.
configuration
    .AddJsonFile("appsettings.json")
    .AddJsonFile("appsettings.development.json")
    .AddUserSecrets(typeof(Program).Assembly);

serviceCollection.AddSingleton(configuration.GetSection("SpeechServiceSettings").Get<SpeechServiceSettings>());
serviceCollection.AddSingleton<ISpeechRecognizerService, SpeechRecognizerService>();

serviceCollection.AddDal(configuration);
serviceCollection.AddAppCore();
serviceCollection.AddControllersWithViews();

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
