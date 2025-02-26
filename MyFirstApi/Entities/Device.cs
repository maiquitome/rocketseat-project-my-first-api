
namespace MyFirstApi.Entities;

public abstract class Device
{
    public abstract string SerialNumber { get; }

    protected bool IsConnected() => false;

    public abstract string GetBrand(); // força todas as classes filhas a implementarem

    public void Test()
    {
        var x = IsConnected();
    }

    public virtual string Hello() => "Hello";
}
