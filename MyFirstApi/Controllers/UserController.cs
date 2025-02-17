using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    // [Route("{id}/{nickname}")]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    // public IActionResult Get([FromHeader] int id, [FromHeader] string? nickname)
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new User
        {
            Name = "John Doe",
            Age = 30
        };

        // return Ok(new { Id = 1, Name = "John Doe" });
        return Ok(response);
    }
}
