namespace IMDBLite.Controllers;

using Microsoft.AspNetCore.Mvc;

[Route("[action]")]
public class MovieController : Controller {
    private readonly ILogger<HomeController> _logger;

    public MovieController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IActionResult Movie(long id){

        ViewData["Title"] = "Das Schweigen der Lämmer";
        return View("MovieDetails");
    }
}