using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Uppgift5_Garage.Entities;

namespace Uppgift5_Garage.Storage
{
    public class Garage
    {
        private ParkingSpot[] parkingSpots;

        public int Size { get; }

        public List<Vehicle> vehicleList { get; } = new List<Vehicle>();

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