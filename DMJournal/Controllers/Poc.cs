
using DMJournal.Interfaces;
using DMJournal.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DMJournal.Controllers;

[ApiController()]
[Route("api/poc")]
public class PocController : Controller
{

    private readonly IParserService _parserService;
    private readonly IRenderService _renderService;

    public PocController(IParserService parserService, IRenderService renderService)
    {
        _parserService = parserService ?? throw new ArgumentNullException(nameof(parserService));
        _renderService = renderService ?? throw new ArgumentNullException(nameof(renderService));
    }


    [HttpGet("render-monster-test")]
    public IActionResult RenderMonsterTest()
    {
        string exampleText = "!!Monster[Name: Goblin Cutre, HP:7, AC:13]";
        
        ParsedMonsterDto? parsedMonster = _parserService.ParseMonster(exampleText);

            if (parsedMonster == null)
            {
                return BadRequest("Error al parsear el monstruo.");
            }

            string htmlResultante = _renderService.RenderMonster(parsedMonster);

            // Devolvemos el HTML directamente para verlo en el navegador
            return Content(htmlResultante, "text/html");;
    }
    
}