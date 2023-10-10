using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Uppgift5_Garage.Storage
{
    public class Garage
    {
        private ParkingLot[] parkingLots;
        public int Size { get; }

        public Garage(int size)
        {
            Size = size;
            parkingLots = new ParkingLot[size];

            for (int p = 0; p < size; p++)
            {
                parkingLots[p] = new ParkingLot();
            }
        }
        [return: MaybeNull]
        public ParkingLot GetSpot(int index)
        {
            return (index < 0 || index > parkingLots.Length) ? null : parkingLots[index];
        }
    }
}