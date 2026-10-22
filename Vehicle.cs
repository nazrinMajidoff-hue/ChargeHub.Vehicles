namespace ChargeHub.Vehicles;

public class Vehicle : IReportable
{
    public string Id { get; }
    public double BatteryKwh { get; }
    public double Percent { get; private set; }

    public Vehicle(string id, double batteryKwh, double percent)
    {
        Id = id;
        BatteryKwh = batteryKwh;
        Percent = percent;
    }

    public string GetReport()
    {
        return $"Bil {Id}: {Percent} %";
    }

    public void Charge(double kwh)
    {
        if (kwh <= 0)
            throw new ArgumentOutOfRangeException(nameof(kwh));

        Percent = Math.Min(100, Percent + kwh / BatteryKwh * 100);
    }
}