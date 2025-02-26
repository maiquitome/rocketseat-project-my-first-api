using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers;

public class UserController : MyFirstApiBaseController
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

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUserJson
        {
            Id = 1,
            Name = request.Name
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    // [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete(/* [FromRoute] int id */)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>()
        {
            new() {Id = 1, Age = 32, Name = "maiqui"},
            new() {Id = 2, Age = 62, Name = "maria"}
        };

        string key = GetCustomKey();

        return Ok(response);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }

    [HttpPut("change-maiqui")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword2([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }
}
