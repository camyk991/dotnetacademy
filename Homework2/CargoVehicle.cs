using System;
namespace Homework2
{
    public class CargoVehicle : Vehicle
    {
        public int CargoWeight { get; set; }


        public CargoVehicle()
        {
            Type = "CARGO";
        }

        override public decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient)
        {
            return CalculateBaseOfRentalCost(durationOfTrip, travelDistance, carCoefficient) + CargoWeight;
        }

    }
}

