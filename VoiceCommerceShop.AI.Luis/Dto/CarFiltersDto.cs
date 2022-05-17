namespace VoiceCommerceShop.AI.Luis.Dto;

public record CarFiltersDto(string Brand, string Model, string Color)
{
    public static CarFiltersDto Default => new(string.Empty, string.Empty, string.Empty);
}