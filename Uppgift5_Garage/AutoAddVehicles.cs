namespace Uppgift5_Garage
{
    public class AutoAddVehicles
    {
        //public bool Done { get; set; }

        public AutoAddVehicles(IGarage garage)
        {                        
                Vehicle vehicle1 = new Airplane { Color = "Blue", LicensePlate = "NEV693", NoOfEngines = 6, NoOfWheels = 4, VehiclePosition = 1 };
                Vehicle vehicle2 = new Motorcycle { Color = "Red", LicensePlate = "BOR622", NoOfWheels = 2, CylinderVolume = 1600, VehiclePosition = 3 };
                Vehicle vehicle3 = new Car { Color = "Yellow", LicensePlate = "TUW943", NoOfWheels = 4, FuleType = "Diesel", VehiclePosition = 6 };
                Vehicle vehicle4 = new Spaceship { Color = "Silver", LicensePlate = "GIR395", HomePlanet = "Uranus", VehiclePosition = 7 };
                Vehicle vehicle5 = new Boat { Color = "Purple", LicensePlate = "YOA353", Length = 13, VehiclePosition = 8 };
                Vehicle vehicle6 = new Car { Color = "Brown", LicensePlate = "USG632", FuleType = "Diesel", VehiclePosition = 10 };

                if (garage.Size >= vehicle1.VehiclePosition + 1) { garage.Park(vehicle1); }
                if (garage.Size >= vehicle2.VehiclePosition + 1) { garage.Park(vehicle2); }
                if (garage.Size >= vehicle3.VehiclePosition + 1) { garage.Park(vehicle3); }
                if (garage.Size >= vehicle4.VehiclePosition + 1) { garage.Park(vehicle4); }
                if (garage.Size >= vehicle5.VehiclePosition + 1) { garage.Park(vehicle5); }
                if (garage.Size >= vehicle6.VehiclePosition + 1) { garage.Park(vehicle6); }                      
        }

    }
}