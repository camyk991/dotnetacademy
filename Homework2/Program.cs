using Homework2;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

class Program
{
    static void Main()
    {
        //var Transport1 = new PassengerVehicle
        //{
        //    Brand = "Ferrari",
        //    Model = "Spider",
        //    YearOfManufacture = 2022,
        //    Color = "Red",
        //    Price = 2500000,
        //    RegistrationNumber = "ABC123",
        //    Mileage = 50,
        //    LesseeRating = 10 
        //};

        //var Transport2 = new PassengerVehicle
        //{
        //    Brand = "Ferrari",
        //    Model = "Spider",
        //    YearOfManufacture = 2022,
        //    Color = "Red",
        //    Price = 2500000,
        //    RegistrationNumber = "ABC123",
        //    Mileage = 50,
        //    LesseeRating = 10
        //};

        //var Transport3 = new PassengerVehicle
        //{
        //    Brand = "Ferrari",
        //    Model = "Spider",
        //    YearOfManufacture = 2022,
        //    Color = "Red",
        //    Price = 2500000,
        //    RegistrationNumber = "ABC123",
        //    Mileage = 50,
        //    LesseeRating = 10,
        //};

        //var Cargo1 = new CargoVehicle
        //{
        //    Brand = "MAN",
        //    Model = "TRUCKMODEL",
        //    YearOfManufacture = 2002,
        //    Color = "Red",
        //    Price = 2500000,
        //    RegistrationNumber = "ABC12322",
        //    Mileage = 503,
        //    CargoWeight = 1000
        //};


        //var price = Transport3.CalculateRentalCost(5, 2000, 2);

        //Console.WriteLine(price.ToString());

        //price = Cargo1.CalculateRentalCost(5, 2000, 2);

        //Console.WriteLine(price.ToString());

        var VehicleFleet = new VehicleFleet();

        VehicleFleet.AddVehicleToFleet(new PassengerVehicle
        {
            Brand = "Nissan",
            Model = "NisModel",
            YearOfManufacture = 2022,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 50,
            LesseeRating = 10
        });

        VehicleFleet.AddVehicleToFleet(new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2022,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 50,
            LesseeRating = 10
        });

        VehicleFleet.AddVehicleToFleet(new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2022,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 50,
            LesseeRating = 10,
        });

        VehicleFleet.AddVehicleToFleet(new CargoVehicle
        {
            Brand = "MAN",
            Model = "TRUCKMODEL",
            YearOfManufacture = 2002,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC12322",
            Mileage = 503,
            CargoWeight = 1000
        });

        Console.WriteLine("Displaying vehicles with band of Ferrari:");
        VehicleFleet.DisplayVehiclesOfSpecifiedBrand("ferrari");
    }
}
