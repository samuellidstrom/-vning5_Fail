using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Uppgift5_Garage.Storage
{
    public class Garage//<T>where T : class
    {
        private ParkingSpot[] parkingSpots;

        public int Size { get; }



        public Garage(int size)
        {
            Size = size;
            parkingSpots = new ParkingSpot[size];

            for (int p = 0; p < size; p++)
            {
                parkingSpots[p] = new ParkingSpot();
            }
        }
        [return: MaybeNull]
        internal ParkingSpot GetSpot(int index)
        {
            return (index < 0 || index > parkingSpots.Length) ? null : parkingSpots[index];
        }
    }
}