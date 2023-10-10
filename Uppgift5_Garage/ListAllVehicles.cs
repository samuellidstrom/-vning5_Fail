namespace Uppgift5_Garage
{
    internal class ListAllVehicles
    {
        public ListAllVehicles(List<Vehicle> allVehicles, IGarage garage)
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Vehicles currently parked in your garage:");
            VisualHandler.ColorsMenu();
            int y = 21;
            foreach (var vehicle in allVehicles)
            {
                Console.SetCursorPosition(1, y);                
                if (allVehicles.Count <= garage.Size)
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
    }
}