using Microsoft.AspNetCore.Mvc;

namespace Practical_16.Controllers;


[Route("api/[controller]")]
[ApiController]
public class HelloWorldController : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetMessage()
    {
        _logger.LogInformation("Hello World Api called");

        return Ok("Hello World !!!!!!!");
    }
}