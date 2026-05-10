using Microsoft.AspNetCore.Mvc;
using Practical_17.Services.Interfaces;

namespace Practical_17.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = _service.GetAllUsers();

        return Ok(users);
    }
}