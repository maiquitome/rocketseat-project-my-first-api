namespace MyFirstApi.Entities;

public class Laptop : Device
{
    public override string SerialNumber => "987654";

    public override string GetBrand() => "Apple";

    public string GetModel()
    {
        bool isConnected = IsConnected();
        if (isConnected)
            return "MacBook";

        return "Unknown";
    }
}
