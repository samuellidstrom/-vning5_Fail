namespace Uppgift5_Garage.Entities
{
    internal class Bus : Vehicle
    {

        public int NoOfSeats { get; set; }
        public override string AllInfo()
        {
            return $"{base.AllInfo()} | Number of seats {NoOfSeats}";
        }
    }
}