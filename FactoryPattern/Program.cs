using System.Threading.Channels;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does the vehicle have?");
            var input = int.TryParse(Console.ReadLine(), out var userInput);
            while (input == false)
            {
                Console.WriteLine("Please enter a valid number");
                input = int.TryParse(Console.ReadLine(), out userInput);
            }
            
            var vehicle = VehicleFactory.GetVehicle(userInput);
            vehicle.Drive();
        }
    }
}
