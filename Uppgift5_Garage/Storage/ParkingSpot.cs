namespace Uppgift5_Garage.Storage
{
    internal class ParkingSpot : IHandler
    {
        public string Symbol => "O";
        public ConsoleColor SpotColor { get; } = ConsoleColor.Green;
        //public ParkingSpot()
        //{
        //    SpotColor = ConsoleColor.Green;
        //}
    }
}