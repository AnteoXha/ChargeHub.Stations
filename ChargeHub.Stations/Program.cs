using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ChargingStation station = new ChargingStation("AC-01", 11);

            station.StartCharging();
            Console.WriteLine($"Stazione {station.Id} avviata con successo. Disponibile: {station.IsAvailable}");

            station.StartCharging();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Felmeddelande: {ex.Message}");
        }
    }
}