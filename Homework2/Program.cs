using System;
using System.Collections.Generic;

// Base Vehicle class
public abstract class Vehicle
{

    public int Id { get; private set; } // Autoincremented ID
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearOfManufacture { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public string RegistrationNumber { get; set; }
    public int Mileage { get; set; }

    public static decimal PriceForKilometer = 0.30M;
    private static int nextAvailableId = 0;

    public Vehicle()
    {
        Id = nextAvailableId;
        nextAvailableId++;
    }


    protected decimal CalculateBaseOfRentalCost(int durationOfTrip, int travelDistance, int carCoefficient)
    {
        var result = ((travelDistance * PriceForKilometer) + durationOfTrip) * (1 + (carCoefficient / 100));

        return result;
    }

    public abstract decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient);

}

public class PassengerVehicle : Vehicle
{
    
    public int LesseeRating { get; set; }

    override public decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient)
    {
        return CalculateBaseOfRentalCost(durationOfTrip, travelDistance, carCoefficient) + LesseeRating;
    }
}


public class CargoVehicle : Vehicle
{
    public int CargoWeight { get; set; }


    override public decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient)
    {
        return CalculateBaseOfRentalCost(durationOfTrip, travelDistance, carCoefficient) + CargoWeight;
    }

}



class Program
{
    static void Main()
    {
        var Transport1 = new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2022,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 50,
            LesseeRating = 10 
        };

        var Transport2 = new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2022,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 50,
            LesseeRating = 10
        };

        var Transport3 = new PassengerVehicle
        {
            Brand = "Ferrari",
            Model = "Spider",
            YearOfManufacture = 2022,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC123",
            Mileage = 50,
            LesseeRating = 10
        };

        var Cargo1 = new CargoVehicle
        {
            Brand = "MAN",
            Model = "TRUCKMODEL",
            YearOfManufacture = 2002,
            Color = "Red",
            Price = 2500000,
            RegistrationNumber = "ABC12322",
            Mileage = 503,
            CargoWeight = 1000
        };


        var price = Transport3.CalculateRentalCost(5, 2000, 2);

        Console.WriteLine(price.ToString());

        price = Cargo1.CalculateRentalCost(5, 2000, 2);

        Console.WriteLine(price.ToString());
    }
}
