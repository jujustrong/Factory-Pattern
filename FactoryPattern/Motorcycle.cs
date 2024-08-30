namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public int Wheels { get; set; }
    
    public void Drive()
    {
        Console.WriteLine("Building a new Motorcycle!");
    }
}