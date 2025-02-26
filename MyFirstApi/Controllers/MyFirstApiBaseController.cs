using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Maiqui Tomé";

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
