using Microsoft.AspNetCore.Mvc;

namespace TaskFlow.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = new[]
        {
            new { Id = Guid.NewGuid(), FirstName = "Nika", LastName = "Gelashvili", Email = "nika@test.com" },
            new { Id = Guid.NewGuid(), FirstName = "Ana", LastName = "Beridze", Email = "ana@test.com" }
        };

        return Ok(users);
    }
}