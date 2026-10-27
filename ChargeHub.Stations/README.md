# ChargeHub.Stations

Projekt för hantering och kontroll av laddstationer i ChargeHub-systemet. Innehåller logik för maxeffekt, tillgänglighet och undantagshantering (exceptions).# ChargeHub

```mermaid
classDiagram
    class IReportable {
        <<interface>>
        +GetReport() string
    }
    class ChargingStation {
        +string Id
        +double MaxKw
        +GetReport() string
    }
    class Vehicle {
        +int Id
        +int Percent
        +GetReport() string
    }

    ChargingStation ..|> IReportable
    Vehicle ..|> IReportable