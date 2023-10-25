
using Uppgift5_Garage.Storage;
using Uppgift5_Garage.Entities;

namespace Uppgift5_Garage
{
    public class UserInterface //: IUI        
    {
        private IGarage garage = null!;
        private bool exist = false;
       // private List<Vehicle> vehicleList =  new List<Vehicle>();
        private bool autoDone = false;

        private void ListAllVehicles()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Vehicles currently parked in your garage:");
            VisualHandler.ColorsMenu();
            int y = 21;
            foreach (var vehicle in garage)
            {
                Console.SetCursorPosition(1, y);
                if (garage.Count() <= garage.Size)
                {
                    Console.WriteLine(vehicle.AllInfo());
                }
                else
                {
                    break;
                }
                y++;
            }
        }

        public void PrintMainMenu()
        {            
            VisualHandler.MenuClear();
            Console.SetCursorPosition(0, 0);
            VisualHandler.ColorsDefault();
            Console.WriteLine("MAGIC  GARAGE  MANAGER");
            Console.WriteLine("\n Main Menu");
            VisualHandler.ColorsMenu();
            if (exist)
            {
                Console.WriteLine("  1. List All Parked Vehicles");
                Console.WriteLine("  2. Add six pre-designed vehicles to the garage");
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
            VisualHandler.ColorsDefault();
            Console.WriteLine(" User input:\n");
            Console.WriteLine(" Message to user");
        }
        public void DrawGarage()
        {          
            VisualHandler.CursorPositionGarage();
            VisualHandler.ColorsDefault();
            Console.WriteLine("Garage Status");
            VisualHandler.ColorsInfo();
           
                VisualHandler.GarageClear();
                VisualHandler.CursorPositionGarage();
                Console.WriteLine($"  Capacity: {garage.Size} slots | Free lots: {garage.Size - garage.Count()}");
                Console.Write("\n  Parking lots overview:\n   Free: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" O");
                VisualHandler.ColorsInfo();
                Console.Write("   Taken: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("0\n   ");

                for (int spotPosition = 0; spotPosition < garage.Size; spotPosition++)
                {
                    ParkingLot parkingSpot = garage.GetSpot(spotPosition);
                    IHandler space = parkingSpot;
                    ArgumentNullException.ThrowIfNull(parkingSpot, nameof(parkingSpot));

                    foreach (var vehicle in garage)
                    {
                        if (vehicle.VehiclePosition == spotPosition)
                        {
                            space = vehicle;
                            break;
                        }
                    }
                    Console.ForegroundColor = space.SpotColor;
                    Console.Write(space?.Symbol);
                }
            

            Console.ForegroundColor = ConsoleColor.White;
        }
        public void UserInput()
        {            
            VisualHandler.CursorPositionUserInput();
            Console.WriteLine("                                             ");
            VisualHandler.CursorPositionUserInput();
            string input = Console.ReadLine();
            if (input == null || input == "")
            {
                MsgWrongMenuChoice();
            }
            else
            {
                char inputChar = input[0];

                if (input.Length == 1)
                {
                    switch (inputChar)
                    {
                        case '1':
                            VisualHandler.MsgClear();
                            if (garage.Count() < 1)
                            {
                                VisualHandler.PrintMessage();
                                Console.WriteLine("Your garage is empty at the moment.");
                            }
                            else
                            {
                                ListAllVehicles();
                            }
                            break;
                        case '2':                                                       
                            if (autoDone == false)
                            {                                
                                AutoAddVehicles autoAddVehicles = new AutoAddVehicles(garage);
                                VisualHandler.PrintMessage();
                                Console.WriteLine("You sucsessfully added six vehicles to the garage.");
                                autoDone = true;
                            }                            
                            else if (autoDone == true)
                            {
                               VisualHandler.PrintMessage();
                               Console.WriteLine("Auto-generated vehicles already added.");
                            }                                                          
                            break;
                        default:
                            MsgWrongMenuChoice();
                            break;
                    }
                }
                else
                {
                    MsgWrongMenuChoice();
                }
            }
        } 
        public void MsgWrongMenuChoice()
        {
            VisualHandler.PrintMessage();
            Console.WriteLine("Please select something from the menu.");
        }

        public void CreateGarge(int garageSize)
        {
            garage = new Garage(garageSize);
            exist = true;
        }
    }
}