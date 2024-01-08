using System;
using System.Collections.Generic;

// Base Vehicle class
public abstract class Vehicle
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearOfManufacture { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public string RegistrationNumber { get; set; }
    public int Mileage { get; set; }


    public abstract decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient);


}

public class PassengerVehicle : Vehicle
{
    
    public int LesseeRating { get; set; }

    override public decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient)
    {


        return 0;
    }
}


public class CargoVehicle : Vehicle
{
    public int CargoWeight { get; set; }


    override public decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient)
    {


        return 0;
    }

}



class Program
{
    static void Main()
    {
        
    }
}
