namespace FactoryPattern;

public class Car : IVehicle
{
    public int Wheels { get; set; }
    
    public void Drive()
    {
        Console.WriteLine("Building a new car!");
    }
}