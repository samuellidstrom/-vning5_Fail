namespace Uppgift5_Garage.Entities
{
    internal class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; set; }
        public override string AllInfo()
        {
            return $"{base.AllInfo()} | Cylinder Volume: {CylinderVolume}";
        }
    }

}