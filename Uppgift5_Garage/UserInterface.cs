
using Uppgift5_Garage.Storage;
using Uppgift5_Garage.Entities;

namespace Uppgift5_Garage
{
    public class UserInterface : IUI        
    {        
        public void PrintMainMenu(bool exist)
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
        public void DrawGarage(bool garageExist, IGarage garage, List<Vehicle> vehicleList)
        {          
            VisualHandler.CursorPositionGarage();
            VisualHandler.ColorsDefault();
            Console.WriteLine("Garage Status");
            VisualHandler.ColorsInfo();
            if (garageExist)
            {
                VisualHandler.GarageClear();
                VisualHandler.CursorPositionGarage();
                Console.WriteLine($"  Capacity: {garage.Size} slots | Free lots: {garage.Size - vehicleList.Count}");
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

                    foreach (var vehicle in vehicleList)
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
            }
            else { Console.WriteLine("  No garage exists at the moment"); }

            Console.ForegroundColor = ConsoleColor.White;
        }
        public void UserInput(bool garageExist, List<Vehicle> allVehicles, AutoDone autoDone, IGarage garage)
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

                if (input.Length == 1 && garageExist == true)
                {
                    switch (inputChar)
                    {
                        case '1':
                            VisualHandler.MsgClear();
                            if (allVehicles.Count < 1)
                            {
                                VisualHandler.PrintMessage();
                                Console.WriteLine("Your garage is empty at the moment.");
                            }
                            else
                            {
                                ListAllVehicles listAllVehicles = new ListAllVehicles(allVehicles, garage);
                            }
                            break;
                        case '2':                                                       
                            if (autoDone.Done == false)
                            {                                
                                AutoAddVehicles autoAddVehicles = new AutoAddVehicles(allVehicles, garage);
                                VisualHandler.PrintMessage();
                                Console.WriteLine("You sucsessfully added six vehicles to the garage.");
                                autoDone.Done = true;
                            }                            
                            else if (autoDone.Done == true)
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
    }
}