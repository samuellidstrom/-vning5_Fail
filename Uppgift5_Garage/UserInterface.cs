using Uppgift5_Garage.Entities;
using Uppgift5_Garage.Storage;

namespace Uppgift5_Garage
{
    public class UserInterface
    {
        //public UserInterface()
        //{


        //}

        private int myVar;

        public void MainMenu(bool exist)
        {
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Main Menu:");

            if (exist)
            {
                Console.WriteLine(" 1. List All Parked Vehicles");
                Console.WriteLine(" 2. Lista fordonstyper - Visar hur många som finns av varje sort");
                Console.WriteLine(" 3. Lägga till fordon");
                Console.WriteLine(" 4. Ta bort fordon");
                Console.WriteLine(" 5. Sätta en kapacitet när nytt garage skapas");
                Console.WriteLine(" 6. Lägg till 6 stycken fordon automatiskt");
                Console.WriteLine(" 7. Sök efter ett fordon via registreringsnummer (ska funka att blanda versaler/små bokstäver");
                Console.WriteLine(" 8. Sök efter fordon utifrån en egenskap eller flera");
                Console.WriteLine(" 9. Få bekräftelse på att det gått bra eller dåligt (exempel att ett fordonparkerats mm)");
            }
            if (exist == false)
            {
                Console.WriteLine(" 1. Skapa ett garage");
            }
        }

        public void DrawGarage(Garage garage, List<Vehicle> vehicleList)
        {
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Garage Status:");
            Console.WriteLine($"Capacity: {garage.Size} slots | Free lots: {garage.Size - vehicleList.Count}");
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
            Console.ForegroundColor = ConsoleColor.White;
        }


        public void PrintVehicle(string message)
        {

        }
        public void GetInput(string message)
        {

        }



    }
}