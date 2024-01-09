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
            ComfortClass = 1,
            StartOfServiceDate = DateTime.Parse("2000.01.09"),
            LesseeRating = 10
        });

        VehicleFleet.AddVehicleToFleet(new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2022,
            Color = "Blue",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 1000001,
            ComfortClass = 1,
            StartOfServiceDate = DateTime.Parse("2022.01.09"),
            LesseeRating = 10
        });

        VehicleFleet.AddVehicleToFleet(new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2022,
            Color = "Yellow",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 14500,
            ComfortClass = 3,
            StartOfServiceDate = DateTime.Parse("2010.01.09"),
            LesseeRating = 10,
        });

        VehicleFleet.AddVehicleToFleet(new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2002,
            Color = "Yellow",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 50,
            ComfortClass = 3,
            StartOfServiceDate = DateTime.Parse("2010.01.09"),
            LesseeRating = 10,
        });

        VehicleFleet.AddVehicleToFleet(new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2022,
            Color = "Yellow",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 50,
            ComfortClass = 1,
            StartOfServiceDate = DateTime.Parse("2010.01.09"),
            LesseeRating = 10,
        });

        VehicleFleet.AddVehicleToFleet(new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2002,
            Color = "Yellow",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 4001,
            ComfortClass = 5,
            StartOfServiceDate = DateTime.Parse("2010.01.09"),
            LesseeRating = 10,
        });

        VehicleFleet.AddVehicleToFleet(new CargoVehicle
        {
            Brand = "MAN",
            Model = "TRUCKMODEL",
            YearOfManufacture = 2002,
            Color = "Green",
            Price = 2500000,
            RegistrationNumber = "ABC12322",
            Mileage = 503,
            ComfortClass = 5,
            StartOfServiceDate = DateTime.Parse("2011.01.09"),
            CargoWeight = 1000
        });

        VehicleFleet.AddVehicleToFleet(new CargoVehicle
        {
            Brand = "MAN",
            Model = "TRUCKMODEL",
            YearOfManufacture = 2004,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC12322",
            Mileage = 2000000,
            ComfortClass = 4,
            StartOfServiceDate = DateTime.Parse("2011.01.09"),
            CargoWeight = 1000
        });

        VehicleFleet.AddVehicleToFleet(new CargoVehicle
        {
            Brand = "Solaris",
            Model = "Bus",
            YearOfManufacture = 2024,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC12322",
            Mileage = 44700,
            ComfortClass = 4,
            StartOfServiceDate = DateTime.Parse("2024.01.08"),
            CargoWeight = 1000
        });

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
}
