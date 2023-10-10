namespace Uppgift5_Garage.Storage
{
    public class ParkingLot : IHandler
    {
        public string Symbol => "O";
        public ConsoleColor SpotColor { get; } = ConsoleColor.Green;
        //public ParkingSpot()
        //{
        //    SpotColor = ConsoleColor.Green;
        //}
    }
}