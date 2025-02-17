using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var response = new Response
        {
            Name = "John Doe",
            Age = 30
        };

        // return Ok(new { Id = 1, Name = "John Doe" });
        return Ok(response);
    }
}
