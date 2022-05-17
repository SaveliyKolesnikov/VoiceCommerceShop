using VoiceCommerceShop.AI.Luis.Dto;

namespace VoiceCommerceShop.AI.Luis.Interfaces;

public interface ICarQueryRequestAnalyzer
{
    Task<CarFiltersDto> ParseUserSearchIntents(string userRequestText);
}