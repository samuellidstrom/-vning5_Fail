using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Uppgift5_Garage
{
    public class Program
    {

        //private static IUI ui = new UserInterface();
        //private List<Vehicle> allVehicles = new List<Vehicle>();
        //private static UserInterface userInterface = new UserInterface();
        
        static void Main(string[] args)
        {
            var garage = new Garage(10);
            var operations = new Operations(new UserInterface(), garage);
            operations.Run();
            
            Console.WriteLine("Program avslutat");
            Console.ReadKey();
            Environment.Exit(0);
           
            Console.ReadKey();
        }

    }
}