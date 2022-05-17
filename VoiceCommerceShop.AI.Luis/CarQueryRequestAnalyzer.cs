using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models;
using Newtonsoft.Json.Linq;
using VoiceCommerceShop.AI.Luis.Config;
using VoiceCommerceShop.AI.Luis.Dto;
using VoiceCommerceShop.AI.Luis.Interfaces;

namespace VoiceCommerceShop.AI.Luis;

public class CarQueryRequestAnalyzer : ICarQueryRequestAnalyzer
{
    private const string CarSearchEntityName = "CarSearch";
    private const string BrandEntityName = "Brand";
    private const string ModelEntityName = "Model";
    private const string ColorEntityName = "Color";
    private static CarFiltersDto DefaultFilterValue => new(string.Empty, string.Empty, string.Empty);

    private readonly LuisServiceSettings settings;

    public CarQueryRequestAnalyzer(LuisServiceSettings settings)
    {
        this.settings = settings;
    }

    public async Task<CarFiltersDto> ParseUserSearchIntents(string userRequestText)
    {
        var credentials = new ApiKeyServiceClientCredentials(settings.SubscriptionKey);
        var runtimeClient = new LUISRuntimeClient(credentials) { Endpoint = settings.PredictionEndpoint };
        
        var request = new PredictionRequest { Query = userRequestText };
        var prediction = await runtimeClient.Prediction.GetSlotPredictionAsync(Guid.Parse(settings.AppId), settings.SlotName, request);

        var entities = prediction.Prediction.Entities;

        if (!entities.TryGetValue(CarSearchEntityName, out var carSearchEntity) ||
            carSearchEntity is not JToken carSearchEntities)
        {
            return DefaultFilterValue;
        }

        var carSearchParams = carSearchEntities.Children().FirstOrDefault();

        if (carSearchParams is null)
        {
            return DefaultFilterValue;
        }

        static string TryGetOrDefault(JToken entities, string path) => entities.SelectToken(path)?.First()?.Value<string>() ?? string.Empty;

        return new CarFiltersDto(
            TryGetOrDefault(carSearchParams, BrandEntityName),
            TryGetOrDefault(carSearchParams, ModelEntityName),
            TryGetOrDefault(carSearchParams, ColorEntityName)
        );
    }
}