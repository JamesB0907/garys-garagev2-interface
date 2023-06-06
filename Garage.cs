using System;
using System.Collections.Generic;

public interface IElectricVehicle
{
    double CurrentChargePercentage { get; }
    void ChargeBattery();
}
public interface IGasVehicle
{
    double CurrentTankPercentage { get; }
    void RefuelTank();
}
public class Vehicle
{
    public double CurrentChargePercentage { get; set; }
    public double CurrentTankPercentage { get; set; }
}

public class Zero : Vehicle, IElectricVehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }
}

public class Cessna : Vehicle, IGasVehicle
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }
}

public class Tesla : Vehicle, IElectricVehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }
}

public class Ram : Vehicle, IGasVehicle
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }
}