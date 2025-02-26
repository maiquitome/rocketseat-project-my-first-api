namespace MyFirstApi.Entities;

public sealed class Laptop : Device
{
    public override string SerialNumber => "987654";

    public override string GetBrand() => "Apple";

    public override string Hello() => $"{base.Hello()} Apple!";

    public string GetModel()
    {
        bool isConnected = IsConnected();
        if (isConnected)
            return "MacBook";

        return "Unknown";
    }
}
