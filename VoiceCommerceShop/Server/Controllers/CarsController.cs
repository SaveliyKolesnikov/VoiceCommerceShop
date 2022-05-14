using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoiceCommerceShop.AppCore.Responses;
using VoiceCommerceShop.DAL;

namespace VoiceCommerceShop.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IMapper mapper;
        private readonly ILogger<CarsController> logger;

        public CarsController(DataContext context, IMapper mapper, ILogger<CarsController> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<CarResponse>> Get()
        {
            var cars = await context.Cars.ToArrayAsync();
            
            return mapper.Map<IEnumerable<CarResponse>>(cars);
        }
    }
}