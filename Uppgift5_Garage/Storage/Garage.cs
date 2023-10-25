using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Uppgift5_Garage.Storage
{
    public class Garage : IGarage
    {
        private ParkingLot[] parkingLots;
        public int Size { get; }
        public int Count { get; private set; }

        public Garage(int size)
        {
            Size = size;
            parkingLots = new ParkingLot[size];

            for (int p = 0; p < size; p++)
            {
                parkingLots[p] = new ParkingLot(null);
            }
        }
        [return: MaybeNull]
        public ParkingLot GetSpot(int index)
        {
            return (index < 0 || index > parkingLots.Length) ? null : parkingLots[index];
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            foreach (var item in parkingLots)
            {
                if(item.Vehicle != null)
                    yield return item.Vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Park(Vehicle vehicle)
        {
            ArgumentNullException.ThrowIfNull(nameof(vehicle));

            for (int i = 0; i < parkingLots.Length; i++)
            {
                if (parkingLots[i].Vehicle == null)
                {
                    parkingLots[i].Vehicle = vehicle;
                    Count++;
                    break;
                }
            }
        }
    }
}