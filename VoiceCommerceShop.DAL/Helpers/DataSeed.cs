using VoiceCommerceShop.Domain;

namespace VoiceCommerceShop.DAL.Helpers;

public static class DataSeed
{
    public static IEnumerable<Car> GetCars()
    {
        return new[]
        {
            new Car(Guid.NewGuid(), "Toyota", "Auris","White", 15000d),
            new Car(Guid.NewGuid(), "Volkswagen", "Passat","Black", 12000d),
            new Car(Guid.NewGuid(), "Mitsubishi", "Lancer","Blue", 8500d),
            new Car(Guid.NewGuid(), "Volkswagen", "Polo","Grey", 6500d),
            new Car(Guid.NewGuid(), "Mazda", "3","Black", 6300d),
        };
    }
}