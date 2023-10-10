namespace Uppgift5_Garage
{
    public interface IUI
    {
        void ColorsDefault();
        void ColorsInfo();
        void ColorsMenu();
        void CursorPositionGarage();
        void CursorPositionUserInput();
        void DrawGarage(bool garageExist, IGarage garage, List<Vehicle> vehicleList);
        void MenuClear();
        void MsgClear();
        void MsgWrongMenuChoice();
        //void PrintCreateGarage();
        void PrintMainMenu(bool exist);
        void PrintMessage();
        void PrintVehicle(string message);
        void UserInput(bool garageExist, List<Vehicle> allVehicles, AutoDone autoDone);

    }
}