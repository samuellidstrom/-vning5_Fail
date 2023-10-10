using Uppgift5_Garage.Storage;

namespace Uppgift5_Garage.Entities
{
    public class Vehicle : IHandler
    {
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public int NoOfWheels { get; set; }
        public string Symbol => "0";
        public ConsoleColor SpotColor { get; } = ConsoleColor.Red;
        public int VehiclePosition { get; set; }

        public virtual string AllInfo()
        {            
            string returnString = $"Parking Lot: {VehiclePosition+1} | Type: {GetType().Name} | Color: {Color} | License Plate: {LicensePlate}"; 
            if (NoOfWheels > 0)
            {
                returnString = returnString + $" | Number of wheels: {NoOfWheels}";
            }
            return returnString;   
        }
    }
}