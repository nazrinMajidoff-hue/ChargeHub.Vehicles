using ChargeHub.Vehicles;

Vehicle car = new Vehicle("EV-01", 75, 20);

car.Charge(30);
Console.WriteLine($"After 30 kWh: {car.Percent}%");

car.Charge(50);
Console.WriteLine($"After another 50 kWh: {car.Percent}%");
