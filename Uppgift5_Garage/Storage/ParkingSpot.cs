namespace Uppgift5_Garage.Storage
{
    public class ParkingLot : IHandler
    {
        public string Symbol => "O";
        public ConsoleColor SpotColor { get; } = ConsoleColor.Green;

        public Vehicle? Vehicle { get; set; }


        public ParkingLot(Vehicle? vehicle)
        {
            Vehicle = vehicle;
        }

        public void Clear()
        {
            Vehicle = default(Vehicle);
        }


    }
}