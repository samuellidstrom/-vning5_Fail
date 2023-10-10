using Uppgift5_Garage.Storage;

namespace Uppgift5_Garage.Entities
{
    internal class Boat : Vehicle
    {
        public int Length { get; set; }
       
        public override string AllInfo()

        {
            return $"{base.AllInfo()} | Length {Length}";
        }
    }
}