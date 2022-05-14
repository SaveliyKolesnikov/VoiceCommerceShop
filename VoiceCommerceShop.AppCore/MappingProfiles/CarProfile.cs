using AutoMapper;
using VoiceCommerceShop.AppCore.Responses;
using VoiceCommerceShop.Domain;

namespace VoiceCommerceShop.AppCore.MappingProfiles;

public class CarProfile : Profile
{
    public CarProfile()
    {
        CreateMap<Car, CarResponse>();
    }
}