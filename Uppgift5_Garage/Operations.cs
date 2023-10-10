
namespace Uppgift5_Garage
{
    internal class Operations
    {
        public IGarage garage;
        //public IGarage garage = null!;
        private List<Vehicle> vehicleList = new List<Vehicle>();
        private Vehicle vehicle = null!;
        bool garageExist = true;
        public IUI userInterface;
        public AutoDone autoDone = new AutoDone();

        //AutoAddVehicles autoAddVehicles = new AutoAddVehicles();
        //private IUI userInterface = new UserInterface();
        public void Run(int x)
        {
            autoDone.Done = false;
            int garageSize = x;
            Initialize(x);
            Execute();
        }

        public Operations(IUI userInterface)
        {
            this.userInterface = userInterface;
        }
        internal void Execute()
        {
            bool running = true;
            do
            {
                userInterface.PrintMainMenu(garageExist);
                userInterface.DrawGarage(garageExist, garage, vehicleList);
                userInterface.UserInput(garageExist, vehicleList, autoDone, garage);
            } while (running);
        }
        public void Initialize(int garageSize)
        {
            garage = new Garage(garageSize);
        }
    }

}