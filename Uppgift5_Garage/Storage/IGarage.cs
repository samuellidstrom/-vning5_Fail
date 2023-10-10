namespace Uppgift5_Garage.Storage
{
    public interface IGarage
    {
        int Size { get; }
        ParkingLot GetSpot(int index);
    }
}