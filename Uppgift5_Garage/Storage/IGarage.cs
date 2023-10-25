using System.Diagnostics.CodeAnalysis;

namespace Uppgift5_Garage.Storage
{
    public interface IGarage : IEnumerable<Vehicle>
    {
        int Size { get; }

        [return: MaybeNull]
        ParkingLot GetSpot(int index);
        void Park(Vehicle vehicle1);
    }
}