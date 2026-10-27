using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IReportable> reportables = new List<IReportable>
        {
            new Vehicle(1, 75.0),
            new ChargingStation("AC-01", 11),
            new ChargingStation("DC-01", 150)
        };

        foreach (var item in reportables)
        {
            Console.WriteLine(item.GetReport());
        }
    }
}