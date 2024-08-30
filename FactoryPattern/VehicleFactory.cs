namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numWheels)
    {
        switch (numWheels)
        {
            case 4:
                return new Car();
            case 2:
                return new Motorcycle();
            default:
                Console.WriteLine("Interesting choice! We'll just get you a car!");
                return new Car();
        }
    }
    
    
    
}