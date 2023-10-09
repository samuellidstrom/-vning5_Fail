﻿
namespace Uppgift5_Garage
{
    internal class Operations
    {
        //private Garage garage = null!;
        private List<Vehicle> vehicleList = new List<Vehicle>();
        private Vehicle vehicle = null!;
        bool garageExist = false;
        UserInterface userInterface = new UserInterface();        

        internal void Run()
        {            
            Initialize();            
            Execute();
        }
        private void Execute()
        {
            bool running = true;
            do
            {
                //här körs programmet när objekten skapats upp.
                userInterface.PrintMainMenu(garageExist);
                //userInterface.PrintMessageDisplay();
                userInterface.DrawGarage(garageExist, garage, vehicleList);
                //Show Menu + Information

                //Get command
                //UserInput();
                userInterface.UnserInput(garageExist);
                //Act

                //Show Menu + Information
            } while (running);
        }

         public void Initialize()
        {
            //ToDo: Fixa så man kan skriva in hur stort garage man vill ha

            //Garage garage = new Garage(0);            
            
            
            //var vSpot = garage.GetSpot(0);

            Vehicle vehicle1 = new Airplane { Color = "Blue", LicensePlate = "Abs452", NoOfEngines = 6, NoOfWheels = 4, VehiclePosition = 1 };
            Vehicle vehicle2 = new Motorcycle { Color = "Red", LicensePlate = "Afw756", NoOfWheels = 2, CylinderVolume = 1600, VehiclePosition = 3 };
            Vehicle vehicle3 = new Car { Color = "Yellow", LicensePlate = "Agd765", NoOfWheels = 4, FuleType = "Diesel", VehiclePosition = 6 };
            Vehicle vehicle4 = new Spaceship { Color = "Silver", LicensePlate = "Gie572", HomePlanet = "Uranus", VehiclePosition = 7 };

            vehicleList.Add(vehicle1);
            vehicleList.Add(vehicle2);
            vehicleList.Add(vehicle3);
            vehicleList.Add(vehicle4);
        }
    }

}