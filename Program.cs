using ChargeHub.Vehicles;

var car = new Vehicle("1", 75, 0);
var ac = new ChargingStation("AC-01", 11);
var dc = new ChargingStation("DC-01", 150);

var reports = new List<IReportable>
{
    car,
    ac,
    dc
};

foreach (var item in reports)
{
    Console.WriteLine(item.GetReport());
}