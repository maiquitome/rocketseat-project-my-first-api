namespace MyFirstApi.Entities;

public class Smartphone : Device
{
    public override string SerialNumber => "123456";

    public override string GetBrand() => "Samsung";
}
