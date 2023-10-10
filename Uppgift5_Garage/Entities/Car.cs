namespace Uppgift5_Garage.Entities
{
    internal class Car : Vehicle
    {
        public string FuleType { get; set; }
        public override string AllInfo()
        {
            return $"{base.AllInfo()} | Fule type: {FuleType}";
        }
    }
}