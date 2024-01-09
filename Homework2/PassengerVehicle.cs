using System;
namespace Homework2
{
    public class PassengerVehicle : Vehicle
    {
        public int LesseeRating { get; set; }

        public PassengerVehicle()
        {
            Type = "PASSENGER";
        }


        override public decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient)
        {
            return CalculateBaseOfRentalCost(durationOfTrip, travelDistance, carCoefficient) + LesseeRating;
        }
    }
}

