using System;

public class ChargingStation : IReportable
{
    public string Id { get; }
    public double MaxKw { get; }
    public bool IsAvailable { get; private set; } = true;

    public ChargingStation(string id, double maxKw)
    {
        if (maxKw <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(maxKw), "MaxKw deve essere maggiore di 0.");
        }
        Id = id;
        MaxKw = maxKw;
    }

    public void StartCharging()
    {
        if (!IsAvailable)
        {
            throw new InvalidOperationException("La stazione è già occupata.");
        }
        IsAvailable = false;
    }

    public void StopCharging()
    {
        IsAvailable = true;
    }

    public string GetReport()
    {
        return $"Station {Id}: {MaxKw} kW";
    }
}