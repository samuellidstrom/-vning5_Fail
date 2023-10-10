using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Uppgift5_Garage.Storage
{
    public class Garage
    {
        private ParkingLot[] parkingSpots;
        public int Size { get; }

        public Garage(int size)
        {
            Size = size;
            parkingSpots = new ParkingLot[size];

            for (int p = 0; p < size; p++)
            {
                parkingSpots[p] = new ParkingLot();
            }
        }
        [return: MaybeNull]
        internal ParkingLot GetSpot(int index)
        {
            return (index < 0 || index > parkingSpots.Length) ? null : parkingSpots[index];
        }
    }
}