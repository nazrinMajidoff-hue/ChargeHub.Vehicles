namespace ChargeHub.Vehicles;

public class Vehicle
{
    public string Id { get; }
    public double BatteryKwh { get; }

    private double _percent;

    public double Percent
    {
        get => _percent;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Percent must be between 0 and 100.");
            }

            _percent = value;
        }
    }

    public Vehicle(string id, double batteryKwh, double percent)
    {
        Id = id;
        BatteryKwh = batteryKwh;
        Percent = percent;
    }
public void Charge(double kwh)
{
    if (kwh <= 0)
    {
        throw new ArgumentOutOfRangeException(
            nameof(kwh),
            "Charging amount must be greater than zero.");
    }

    Percent = Math.Min(100, Percent + (kwh / BatteryKwh * 100));
}

}