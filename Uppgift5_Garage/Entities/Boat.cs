using Uppgift5_Garage.Storage;

namespace Uppgift5_Garage.Entities
{
    internal class Boat : Vehicle
    {
        //public Boat()
        //{
        //    string type = "Boat";
        //    base.Type = type;
        //}

        public int Length { get; set; }
       
        public override string AllInfo()

        {
            return $"{base.AllInfo()} | Length {Length}";
        }
    }
}