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
                Console.WriteLine($"Start of Service Date: {vehicle.StartOfServiceDate}");
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

		public void DisplayVehiclesExceedingOperationalTenure()
		{
			List<Vehicle> vehiclesExceedingOperationalTenure = (List<Vehicle>)VehicleList
				.Where(vehicle =>
				{
                    var yearsInService = DateTime.Now.Year - vehicle.StartOfServiceDate.Year;

                    if (vehicle.Type == "CARGO")
					{
                        return vehicle.Mileage > 1000000 || yearsInService > 15;
                    } else
					{
                        return vehicle.Mileage > 100000 || yearsInService > 5;
                    }
				}

				)
				.ToList();

			DisplayGivenVehicles(vehiclesExceedingOperationalTenure);
        }

		public decimal CalculateTotalValueOfEntireFleet()
		{
			var total = 0M;

			foreach (var vehicle in VehicleList)
			{
				var valueDecreasePerYear = 0M;

				if (vehicle.Type == "CARGO")
				{
					valueDecreasePerYear = 0.07M;
				} else
				{
					valueDecreasePerYear = 0.1M;
				}


                var price = vehicle.Price;
				var yearsDifference = DateTime.Now.Year - vehicle.YearOfManufacture;

				for (var i = 0; i < yearsDifference; ++i)
				{
					price = price - ((valueDecreasePerYear * price));
				}

				total += price;
				
			}

			return total;
		}

		public void DisplayTotalValueOfEntireFleet()
		{
			Console.WriteLine(CalculateTotalValueOfEntireFleet().ToString());
		}
	}
}

