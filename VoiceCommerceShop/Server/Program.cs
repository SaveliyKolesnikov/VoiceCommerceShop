using VoiceCommerceShop.AI.Luis;
using VoiceCommerceShop.AI.Luis.Config;
using VoiceCommerceShop.AI.Luis.Interfaces;
using VoiceCommerceShop.AppCore.DI;
using VoiceCommerceShop.CognitiveServices.Speech;
using VoiceCommerceShop.CognitiveServices.Speech.Config;
using VoiceCommerceShop.DAL.DI;

var builder = WebApplication.CreateBuilder(args);

var serviceCollection = builder.Services;
var configuration = builder.Configuration;

// Add services to the container.
configuration
    .AddJsonFile("appsettings.json")
    .AddUserSecrets(typeof(Program).Assembly);

serviceCollection.AddSingleton(configuration.GetSection("SpeechServiceSettings").Get<SpeechServiceSettings>());
serviceCollection.AddSingleton<ISpeechRecognizerService, SpeechRecognizerService>();

serviceCollection.AddSingleton(configuration.GetSection("LuisServiceSettings").Get<LuisServiceSettings>());
serviceCollection.AddSingleton<ICarQueryRequestAnalyzer, CarQueryRequestAnalyzer>();

serviceCollection.AddDal(configuration);
serviceCollection.AddAppCore();
serviceCollection.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) app.UseHsts();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    "default",
    "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();