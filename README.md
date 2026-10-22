classDiagram
    class IReportable {
        <<interface>>
        GetReport()
    }

    class Vehicle {
        Id
        BatteryKwh
        Percent
        GetReport()
        Charge()
    }

    class ChargingStation {
        Id
        MaxKw
        GetReport()
    }

    IReportable <|.. Vehicle
    IReportable <|.. ChargingStation