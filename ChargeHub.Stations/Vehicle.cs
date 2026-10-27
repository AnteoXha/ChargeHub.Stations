using System;

public class Vehicle : IReportable
{
    public int Id { get; }
    public double BatteryKwh { get; }

    private int _percent;
    public int Percent
    {
        get => _percent;
        set
        {
            if (value < 0) _percent = 0;
            else if (value > 100) _percent = 100;
            else _percent = value;
        }
    }

    public Vehicle(int id, double batteryKwh)
    {
        Id = id;
        BatteryKwh = batteryKwh;
        Percent = 0;
    }

    public void Charge(double kwh)
    {
        if (kwh <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(kwh), "I kWh devono essere maggiori di 0.");
        }

        double addedPercent = (kwh / BatteryKwh) * 100.0;
        Percent += (int)Math.Round(addedPercent);
    }

    public string GetReport()
    {
        return $"Bil {Id}: {Percent} %";
    }
}