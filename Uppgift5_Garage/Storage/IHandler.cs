namespace Uppgift5_Garage.Storage
{
    internal interface IHandler
    {
        ConsoleColor SpotColor { get; }
        string Symbol { get; }
    }
}