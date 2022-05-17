using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.EntityFrameworkCore;
using VoiceCommerceShop.AppCore.Responses;
using VoiceCommerceShop.CognitiveServices.Speech;
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
        private readonly ISpeechRecognizerService speechRecognizerService;

        public CarsController(DataContext context, IMapper mapper, ILogger<CarsController> logger, ISpeechRecognizerService speechRecognizerService)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
            this.speechRecognizerService = speechRecognizerService;
        }

        [HttpGet]
        public async Task<IEnumerable<CarResponse>> Get()
        {
            var cars = await context.Cars.ToArrayAsync();

            return mapper.Map<IEnumerable<CarResponse>>(cars);
        }

        [HttpPost("voice-search")]
        public async Task<ActionResult<string>> VoiceSearch()
        {
            var formFiles = Request.Form.Files;
            if (!formFiles.Any()) return BadRequest();

            await using var reader = formFiles[0].OpenReadStream();
            using var binaryStream = new BinaryReader(reader);

            var res = await speechRecognizerService.RecognizeFromBinaryStream(binaryStream);


            return Ok(res);
        }
    }

    public record Data(IFormFile audio);
}