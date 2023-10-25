
namespace Uppgift5_Garage
{
    internal class Operations
    {
      //  private IGarage garage = null!;
       // private List<Vehicle> vehicleList = new List<Vehicle>();
     //   private Vehicle vehicle = null!;
       // bool garageExist = true;
        private UserInterface userInterface;
        private int garageSize;
        // private AutoDone autoDone = new AutoDone();

        
        public void Run()
        {
           // autoDone.Done = false;
            Initialize();
            Execute();
        }
        public Operations(UserInterface userInterface, int capacity)
        {
            this.userInterface = userInterface;
            garageSize = capacity;
        }
        internal void Execute()
        {
            bool running = true;
            do
            {
                userInterface.PrintMainMenu();
                userInterface.DrawGarage();
                userInterface.UserInput();
            } while (running);
        }
        public void Initialize()
        {
            userInterface.CreateGarge(garageSize);
           // garage = new Garage(garageSize);
        }
    }

}