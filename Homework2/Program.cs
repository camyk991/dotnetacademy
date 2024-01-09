using Homework2;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

class Program
{
    static void Main()
    {

        var VehicleFleet = new VehicleFleet();
        
        GetFleetFromFile(VehicleFleet, "fleet_demo.txt");

        Console.WriteLine("\nDisplaying full fleet:");
        VehicleFleet.DisplayAllVehicles();

        Console.WriteLine("\nDisplaying vehicles with band of Ferrari:");
        VehicleFleet.DisplayVehiclesOfSpecifiedBrand("ferrari");

        Console.WriteLine("\nDisplaying vehicles exceeding operational tenure:");
        VehicleFleet.DisplayVehiclesExceedingOperationalTenure();

        Console.WriteLine("\nDisplaying total value of the fleet owned:");
        VehicleFleet.DisplayTotalValueOfEntireFleet();

        Console.WriteLine("\nDisplaying sorted by comfort class vehicles of brand 'Ferrari' and color 'Yellow'");
        VehicleFleet.DisplayVehiclesOfSpecifiedColorAndBrandSortedByComfortClass("ferrari", "yellow");

        Console.WriteLine("\nDisplaying vehicles requiring maintenace");
        VehicleFleet.DisplayVehiclesRequiringMaintenance();
    }


    private static void GetFleetFromFile(VehicleFleet fleet, string filePath)
    { 
        
        foreach (string line in File.ReadAllLines(filePath))
        {
            string[] vehicleData = line.Split(',');

            string brand = vehicleData[0].Trim();
            string model = vehicleData[1].Trim();
            int yearOfManufacture = int.Parse(vehicleData[2].Trim());
            string color = vehicleData[3].Trim();
            decimal price = decimal.Parse(vehicleData[4].Trim());
            string registrationNumber = vehicleData[5].Trim();
            int mileage = int.Parse(vehicleData[6].Trim());
            string type = vehicleData[7].Trim();
            int comfortClass = int.Parse(vehicleData[8].Trim());
            string startOfServiceDate = vehicleData[9].Trim();

            Vehicle vehicle;
            if (type == "PASSENGER")
            {
                int lesseeRating = int.Parse(vehicleData[10].Trim());
                vehicle = new PassengerVehicle
                {
                    Brand = brand,
                    Model = model,
                    YearOfManufacture = yearOfManufacture,
                    Color = color,
                    Price = price,
                    RegistrationNumber = registrationNumber,
                    Mileage = mileage,
                    ComfortClass = comfortClass,
                    StartOfServiceDate = DateTime.Parse(startOfServiceDate),
                    LesseeRating = lesseeRating
                };
            }
            else
            {
                int cargoWeight = int.Parse(vehicleData[10].Trim());
                vehicle = new CargoVehicle
                {
                    Brand = brand,
                    Model = model,
                    YearOfManufacture = yearOfManufacture,
                    Color = color,
                    Price = price,
                    RegistrationNumber = registrationNumber,
                    Mileage = mileage,
                    ComfortClass = comfortClass,
                    StartOfServiceDate = DateTime.Parse(startOfServiceDate),
                    CargoWeight = cargoWeight
                };
            };
            

            fleet.AddVehicleToFleet(vehicle);
        }
    }
}


