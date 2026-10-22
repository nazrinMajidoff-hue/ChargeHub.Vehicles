namespace ChargeHub.Vehicles;

public class ChargingStation : IReportable
{
    public string Id { get; }
    public double MaxKw { get; }

    public ChargingStation(string id, double maxKw)
    {
        Id = id;
        MaxKw = maxKw;
    }

    public string GetReport()
    {
        return $"Station {Id}: {MaxKw} kW";
    }
}