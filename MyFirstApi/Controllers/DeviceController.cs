using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public ActionResult Get()
    {
        // Author = "maria";

        return Ok(Author);
    }
}
