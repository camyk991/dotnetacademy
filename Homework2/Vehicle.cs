using System;
namespace Homework2

{
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
        public string Type { get; set; }
        public DateTime StartOfServiceDate { get; set; }

        public static decimal PriceForKilometer = 0.30M;
        private static int NextAvailableId = 0;

        public Vehicle()
        {
            Id = NextAvailableId;
            NextAvailableId++;
        }


        protected decimal CalculateBaseOfRentalCost(int durationOfTrip, int travelDistance, int carCoefficient)
        {
            var result = ((travelDistance * PriceForKilometer) + durationOfTrip) * (1 + (carCoefficient / 100));

            return result;
        }

        public abstract decimal CalculateRentalCost(int durationOfTrip, int travelDistance, int carCoefficient);

    }
}

