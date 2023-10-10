using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Uppgift5_Garage
{
    public class Program
    {        
        static void Main(string[] args)
        {            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("MAGIC  GARAGE  MANAGER");            
            Console.WriteLine("\nCreate a garage:");            
            Console.WriteLine("\nPlease enter how many parking lots you want in your garage.");
            int x;
            do
            {
                Console.Write("User Input: ");
                string gSize = Console.ReadLine();
                                
                if (int.TryParse(gSize, out x))
                {
                    Console.WriteLine($"\nYour new garage contains {x} parking lots.\n");
                    Console.Write($"Press any key to start managing your garage...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a number. Try again.");
                }

            } while (true);

            var operations = new Operations(new UserInterface());

            Console.Clear();
            operations.Run(x);
        }
    }
}