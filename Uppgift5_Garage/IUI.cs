namespace Uppgift5_Garage
{
    public interface IUI
    {
        void DrawGarage(bool garageExist, IGarage garage, List<Vehicle> vehicleList);
        void MsgWrongMenuChoice();
        void PrintMainMenu(bool exist);
        void UserInput(bool garageExist, List<Vehicle> allVehicles, AutoDone autoDone, IGarage garage);
    }
}