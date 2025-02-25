namespace MyFirstApi.Entities;

public class Laptop : Device
{
    public string GetModel()
    {
        bool isConnected = IsConnected();
        if (isConnected)
            return "MacBook";

        return "Unknown";
    }
}
