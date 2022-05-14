using AutoMapper;
using VoiceCommerceShop.Domain;
using VoiceCommerceShop.Shared.Responses;

namespace VoiceCommerceShop.AppCore.MappingProfiles;

public class CarProfile : Profile
{
    public CarProfile()
    {
        CreateMap<Car, CarResponse>();
    }
}