namespace Uppgift5_Garage.Entities
{
    internal class Spaceship : Vehicle
    {
        public string HomePlanet { get; set; }
        public override string AllInfo()
        {
            return $"{base.AllInfo()} | Home Planet: {HomePlanet}";
        }
    }
}