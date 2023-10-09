
using Uppgift5_Garage.Storage;
using Uppgift5_Garage.Entities;

namespace Uppgift5_Garage
{
    public class UserInterface
    {
        internal void PrintMainMenu(bool exist)
        {
            MenuClear();
            Console.SetCursorPosition(0, 0);
            ColorsDefault();
            Console.WriteLine("M A G I C   G A R A G E   M A K E R");
            Console.SetCursorPosition(0, 4);
            Console.SetCursorPosition(1, 2);
            ColorsDefault();
            Console.WriteLine("Main Menu             ");
            ColorsMenu();
            if (exist)
            {
                Console.WriteLine("  1. List All Parked Vehicles");
                Console.WriteLine("  2. Add 6 vehicles to the garage.. (cheating)");
                //Console.WriteLine(" 3. Lägg till fordon");
                //Console.WriteLine(" 4. Ta bort fordon");
                //Console.WriteLine(" 5. Sätta en kapacitet när nytt garage skapas");
                //Console.WriteLine(" 6. Lista fordonstyper - Visar hur många som finns av varje sort");
                //Console.WriteLine(" 7. Sök efter ett fordon via registreringsnummer (ska funka att blanda versaler/små bokstäver");
                //Console.WriteLine(" 8. Sök efter fordon utifrån en egenskap eller flera");
                //Console.WriteLine(" 9. Få bekräftelse på att det gått bra eller dåligt (exempel att ett fordonparkerats mm)");
            }
            if (exist == false)
            {
                Console.WriteLine("  1. Create garage");
            }

            Console.SetCursorPosition(0, 9);

            ColorsDefault();
            Console.WriteLine(" User input:\n");
            Console.WriteLine(" Message to user");
            //PrintMessage();
            //Console.WriteLine("Welcome to Magic Garage Maker.");

        }

        internal void PrintCreateGarage()
        {
            MenuClear();
            ColorsDefault();
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("Create Garage:        ");
            ColorsMenu();
            Console.SetCursorPosition(1, 4);
            Console.Write("                           ");
            Console.SetCursorPosition(1, 4);
            Console.Write(" Number of parking lots:");

            while (true)
            {
                ColorsDefault();
                Console.SetCursorPosition(25, 4);
                int x = 0;
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out x))
                {

                    Garage garage = new Garage(x);
                    //Vehicle[] garage1 = new Vehicle[x];
                    MsgClear();
                    PrintMessage();
                    Console.WriteLine($"Your new garage contains {x} parking lots.");
                    CursorPositionUserInput();
                    
                    
                    break;
                }
                else 
                {
                    MsgClear();
                    PrintMessage();
                    Console.WriteLine("Please enter a number.");
                }
            }
        }

        internal void DrawGarage(bool garageExist, Garage garage, List<Vehicle> vehicleList)
        {
            //IHandler space;
            //Console.SetCursorPosition(0, 12);
            //HeadLine();

            CursorPositionGarage();
            ColorsDefault();
            Console.WriteLine("Garage Status");
            ColorsInfo();
            if (garageExist)
            {
                Console.WriteLine($"  Capacity: {garage.Size} slots | Free lots: {garage.Size - vehicleList.Count}");
                Console.Write("\n  Parking lot overview:\n   Free:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" O");
                ColorsInfo();
                Console.Write("   Taken: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("0\n   ");

                for (int spotPosition = 0; spotPosition < garage.Size; spotPosition++)
                {
                    ParkingSpot parkingSpot = garage.GetSpot(spotPosition);
                    IHandler space = parkingSpot;
                    ArgumentNullException.ThrowIfNull(parkingSpot, nameof(parkingSpot));

                    foreach (var vehicle in vehicleList)
                    {
                        if (vehicle.VehiclePosition == spotPosition)
                        {
                            space = vehicle;
                            break;
                        }
                    }
                    Console.ForegroundColor = space.SpotColor;
                    Console.Write(space.Symbol);
                }
            }
            else { Console.WriteLine("  No garage exists at the moment"); }

            Console.ForegroundColor = ConsoleColor.White;
        }
        public void PrintVehicle(string message)
        {

        }
        internal void UnserInput(bool garageExist)
        {
            CursorPositionUserInput();
            Console.WriteLine("                                             ");
            CursorPositionUserInput();
            string input = Console.ReadLine();
            if (input == null || input == "")
            {
                MsgWrongMenuChoice();
            }
            else
            {
                char inputChar = input[0];

                if (garageExist)
                {
                    switch (inputChar)
                    {
                        case '1':
                            MsgClear();
                            break;
                        default:
                            MsgWrongMenuChoice();
                            break;
                    }
                }
                else
                {
                    switch (inputChar)
                    {
                        case '1':
                            MsgClear();
                            //PrintCreateGarage(garageExist);
                            break;
                        default:
                            MsgWrongMenuChoice();
                            break;
                    }
                }


            }

        }

        private void MenuClear()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("                                                ");
            }                       
        }
        private void MsgClear()
        {
            PrintMessage();
            Console.WriteLine("                                                ");
        }
        private void MsgWrongMenuChoice()
        {
            PrintMessage();
            Console.WriteLine("Please select something from the menu.");
        }

        private void CursorPositionUserInput()
        {
            Console.SetCursorPosition(13, 9);
        }
        private void CursorPositionGarage()
        {
            Console.SetCursorPosition(1, 14);
        }
        internal void PrintMessage()
        {
            Console.SetCursorPosition(2, 12);
            //MsgClear();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private void ColorsDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ColorsInfo()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        private void ColorsMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private void ColorsError()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}