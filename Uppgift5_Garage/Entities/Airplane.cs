using Uppgift5_Garage.Storage;

namespace Uppgift5_Garage.Entities
{
    internal class Airplane : Vehicle
    {
        public int NoOfEngines { get; set; }

        public override string AllInfo()

        {
            return $"{base.AllInfo()} | Number of engines {NoOfEngines}";
        }
    }
}