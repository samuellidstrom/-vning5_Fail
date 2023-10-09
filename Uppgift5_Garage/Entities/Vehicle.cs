using Uppgift5_Garage.Storage;

namespace Uppgift5_Garage.Entities
{
    internal class Vehicle : IHandler
    {
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public int NoOfWheels { get; set; }
        public string Symbol => "0";
        public ConsoleColor SpotColor { get; } = ConsoleColor.Red;
        public int VehiclePosition { get; set; }

        public virtual string AllInfo()
        {
            //ui.PrintVehicle($"Vehicle typ: {GetType().Name} | Color: {Color} | License Plate: {License Plate}");
            string returnString = $"Vehicle typ: {GetType().Name} | Color: {Color} | License Plate: {LicensePlate}";
            if (NoOfWheels > 0)
            {
                returnString = returnString + $"Number of wheels: {NoOfWheels}";
            }
            return returnString;   
        }

        //public Vehicle(ParkingSpot parkingSpot, string symbol)
        //{
        //    Position = parkingSpot;
        //    //Symbol = symbol;
        //    //SpotColor = ConsoleColor.Red;
        //}
    }
}