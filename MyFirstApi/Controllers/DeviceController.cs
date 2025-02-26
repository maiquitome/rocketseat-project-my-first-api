using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public ActionResult Get()
    {
        // Author = "maria";

        // var device = new Device();


        var laptop = new Laptop();

        string hello = laptop.Hello();

        // Com o modificador `protected` na classe `Device`, o método `isConnected` só pode ser usado na própria classe ou classes filhas
        // laptop.isConnected = true;

        string model = laptop.GetModel();

        string brand = laptop.GetBrand();

        return Ok(hello);
    }
}
