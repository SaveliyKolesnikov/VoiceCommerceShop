namespace VoiceCommerceShop.AppCore.Responses;

public record CarResponse(Guid CarKey, string Brand, string Model, string Color, double Price);