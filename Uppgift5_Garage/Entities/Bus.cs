namespace Uppgift5_Garage.Entities
{
    internal class Bus : Vehicle
    {
        //public Bus()
        //{
        //    string type = "Bus";
        //    base.Type = type;
        //}

        public int NoOfSeats { get; set; }

        public override string AllInfo()

        {
            return $"{base.AllInfo()} | Number of seats {NoOfSeats}";
        }
    }
}