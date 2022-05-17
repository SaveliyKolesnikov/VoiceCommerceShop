using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoiceCommerceShop.AI.Luis.Interfaces;
using VoiceCommerceShop.AppCore.Responses;
using VoiceCommerceShop.CognitiveServices.Speech;
using VoiceCommerceShop.DAL;
using VoiceCommerceShop.Domain;

namespace VoiceCommerceShop.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
    private readonly DataContext context;
    private readonly IMapper mapper;
    private readonly ICarQueryRequestAnalyzer queryRequestAnalyzer;
    private readonly ISpeechRecognizerService speechRecognizerService;

    public CarsController(DataContext context, IMapper mapper,
        ISpeechRecognizerService speechRecognizerService,
        ICarQueryRequestAnalyzer queryRequestAnalyzer)
    {
        this.context = context;
        this.mapper = mapper;
        this.speechRecognizerService = speechRecognizerService;
        this.queryRequestAnalyzer = queryRequestAnalyzer;
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

        var userInputText = await speechRecognizerService.RecognizeFromBinaryStream(binaryStream);

        return userInputText;
    }


    [HttpGet("filter-by-text")]
    public async Task<ActionResult<Car[]>> FilterByText([FromQuery] string inputText)
    {
        var (brand, model, color) = await queryRequestAnalyzer.ParseUserSearchIntents(inputText);

        var filteredCars = await context.Cars.Where(c =>
            c.Brand.Contains(brand) &&
            c.Model.Contains(model) &&
            c.Color.Contains(color)).ToArrayAsync();

        return Ok(filteredCars);
    }
}