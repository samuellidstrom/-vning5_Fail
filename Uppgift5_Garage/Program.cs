using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Uppgift5_Garage
{
    public class Program
    { 
        //Samuel
        static void Main(string[] args)
        {  
            //var li = new List<string>();
            //var r = li.Count();
            //var r2 = li.Count;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("MAGIC  GARAGE  MANAGER");            
            Console.WriteLine("\nCreate a garage:");            
            Console.WriteLine("\nPlease enter how many parking lots you want in your garage.");
            int capacity;
            do
            {
                Console.Write("User Input: ");
                string gSize = Console.ReadLine();
                                
                if (int.TryParse(gSize, out capacity))
                {
                    Console.WriteLine($"\nYour new garage contains {capacity} parking lots.\n");
                    Console.Write($"Press any key to start managing your garage...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a number. Try again.");
                }

            } while (true);

            var operations = new Operations(new UserInterface(), capacity);

            Console.Clear();
            operations.Run();
            
        }
    }
}