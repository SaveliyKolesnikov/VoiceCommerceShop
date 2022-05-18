using VoiceCommerceShop.Domain;

namespace VoiceCommerceShop.DAL.Helpers;

public static class DataSeed
{
    public static IEnumerable<Car> GetCars()
    {
        return new[]
        {
            new Car(Guid.NewGuid(), "Toyota", "Auris", "White", 15000d),
            new Car(Guid.NewGuid(), "Volkswagen", "Passat", "Black", 12000d),
            new Car(Guid.NewGuid(), "Volkswagen", "Passat", "Red", 15000d),
            new Car(Guid.NewGuid(), "Volkswagen", "Passat", "Silver", 13000d),
            new Car(Guid.NewGuid(), "Volkswagen", "Beattle", "Yellow", 15000d),
            new Car(Guid.NewGuid(), "Volkswagen", "Polo", "Grey", 6500d),
            new Car(Guid.NewGuid(), "Volkswagen", "Polo", "Blue", 7500d),
            new Car(Guid.NewGuid(), "Audi", "A6", "Silver", 20000d),
            new Car(Guid.NewGuid(), "Audi", "Q7", "Blue", 40000d),
            new Car(Guid.NewGuid(), "Mitsubishi", "Lancer", "Blue", 8500d),
            new Car(Guid.NewGuid(), "Mitsubishi", "Lancer", "Black", 9000d),
            new Car(Guid.NewGuid(), "Mazda", "6", "Red", 12000d),
            new Car(Guid.NewGuid(), "Mazda", "3", "Black", 6300d)
        };
    }
}