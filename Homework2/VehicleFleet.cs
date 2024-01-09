using System;
namespace Homework2
{
	public class VehicleFleet
	{
		public List<Vehicle> VehicleList = new List<Vehicle>();

		public void AddVehicleToFleet(Vehicle vehicle)
		{
			VehicleList.Add(vehicle);
		}

		private void DisplayGivenVehicles(List<Vehicle> vehicles)
		{
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Id: {vehicle.Id}");
                Console.WriteLine($"Type: {vehicle.Type}");
                Console.WriteLine($"Brand: {vehicle.Brand}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Year of Manufacture: {vehicle.YearOfManufacture}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Price: {vehicle.Price}");
                Console.WriteLine($"Registration Number: {vehicle.RegistrationNumber}");
                Console.WriteLine($"Mileage: {vehicle.Mileage}");
                Console.WriteLine("\n --- \n");
            }
        }

		public void DisplayAllVehicles()
		{
			DisplayGivenVehicles(VehicleList);
		}

		public void DisplayVehiclesOfSpecifiedBrand(string brand)
		{
            List<Vehicle> vehiclesOfSpecifiedBrand = (List<Vehicle>)VehicleList
				.Where(vehicle =>
					{
						return vehicle.Brand.ToLower() == brand.ToLower();
					})
				.ToList();

			DisplayGivenVehicles(vehiclesOfSpecifiedBrand);
		}

		
	}
}

