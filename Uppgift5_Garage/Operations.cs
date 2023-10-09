using Uppgift5_Garage.Entities;
using Uppgift5_Garage.Storage;

namespace Uppgift5_Garage
{
    internal class Operations
    {
        private Garage garage = null!;
        private Vehicle vehicle = null!;

        internal void Run()
        {


            Initialize();
            Execute();
            
            
        }

        private void Execute()
        {
            bool running = true;
            do 
            {
                //här körs programmet när objekten skapats upp.
                DrawGarage();
                //Show Menu + Information

                //Get command
                UserInput();
                //Act

                //Show Menu + Information
                Console.ReadKey();

            } while (running); 
        }

        private void UserInput()
        {
            var keyPressed = Console.ReadKey();
        }

        private void DrawGarage()
        {

            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Garage Status:");
            Console.WriteLine($"Capacity: {garage.Size} slots | Free lots: {garage.Size - garage.vehicles.Count}");
            for (int spotPosition = 0; spotPosition < garage.Size; spotPosition++)
            {
                ParkingSpot parkingSpot = garage.GetSpot(spotPosition);
                IHandler space = parkingSpot;
                ArgumentNullException.ThrowIfNull(parkingSpot, nameof(parkingSpot));

                foreach (var vehicle in garage.vehicles)
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
            Console.ForegroundColor= ConsoleColor.White;
        }

        public void Initialize()
        {
            //ToDo: Fixa så man kan skriva in hur stort garage man vill ha
             
            garage = new Garage(10);
            //vehicle = new Vehicle();
            var vSpot = garage.GetSpot(0);


            Vehicle vehicle1 = new Airplane { Color = "Blue", LicensePlate = "Abs452", NoOfEngines = 6, NoOfWheels = 4, VehiclePosition = 1 };
            Vehicle vehicle2 = new Motorcycle { Color = "Red", LicensePlate = "Afw756", NoOfWheels = 2, CylinderVolume = 1600, VehiclePosition = 3 };
            Vehicle vehicle3 = new Car { Color = "Yellow", LicensePlate = "Agd765", NoOfWheels = 4, FuleType = "Diesel", VehiclePosition = 6 };
            Vehicle vehicle4 = new Spaceship { Color = "Silver", LicensePlate = "Gie572", HomePlanet = "Uranus" , VehiclePosition = 7 };

            garage.vehicles.Add(vehicle1);
            garage.vehicles.Add(vehicle2);
            garage.vehicles.Add(vehicle3);
            garage.vehicles.Add(vehicle4);
            //Airplane airplane = new Airplane();
            //garage.vehicles.Add(airplane);

            //allVehicles = new List<Vehicle>();
            //var userInterface = new UserInterface();
        }
    }

}