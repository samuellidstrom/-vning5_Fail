using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Uppgift5_Garage.Entities;

namespace Uppgift5_Garage
{
    public class Program
    {

        //private static IUI ui = new UserInterface();
        //private List<Vehicle> allVehicles = new List<Vehicle>();
        //private static UserInterface userInterface = new UserInterface();

        
        static void Main(string[] args)
        {

            Operations operations = new Operations();
            operations.Run();
            
            Console.WriteLine("Program avslutat");
            Console.ReadKey();
            Environment.Exit(0);


            

            Vehicle vehicle1 = new Airplane { Color = "Blue", LicensePlate = "Abs452", NoOfEngines = 6, NoOfWheels = 4 };
            Vehicle vehicle2 = new Motorcycle { Color = "Red", LicensePlate = "Afw756", NoOfWheels = 2, CylinderVolume = 1600 };
            Vehicle vehicle3 = new Car { Color = "Yellow", LicensePlate = "Agd765", NoOfWheels = 4, FuleType = "Diesel" };
            Vehicle vehicle4 = new Bus { Color = "Green", LicensePlate = "Afd345", NoOfWheels = 8, NoOfSeats = 24 };
            Vehicle vehicle5 = new Boat { Color = "White", LicensePlate = "gfd762", NoOfWheels = 0, Length = 5 };
            Vehicle vehicle6 = new Spaceship { Color = "Silver", LicensePlate = "gfd762" };
           
            Console.WriteLine("\nAll existing vehicles:");
            
            while (true)
            {
                Console.WriteLine("\nSkapa nytt garage:\nHur många platser ska ditt garage innehålla?");
                int x = 0;
                string y = Console.ReadLine();
                if (int.TryParse(y, out x))
                {
                    Vehicle[] garage1 = new Vehicle[x];
                    Console.WriteLine($"\nDitt nya garage är skapat och innehåller {x}st platser");
                    break;
                }
                else { Console.WriteLine("\nSkriv en siffra."); }
            }

            Console.ReadKey();
        }

    }
}