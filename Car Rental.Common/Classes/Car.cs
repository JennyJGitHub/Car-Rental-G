using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string RegNo { get; init; }
    public string Make { get; init; }
    public double Odometer { get; init; }
    public double CostKm { get; init; }
    public VehicleTypes Type { get; init; }
    public double CostDay { get; init; }
    public VehicleStatuses Status { get; init; }

    public Car (string regNo, string make, double odometer, double costKm,
        VehicleTypes type, double costDay, VehicleStatuses status = VehicleStatuses.Available) =>
        (RegNo, Make, Odometer, CostKm, Type, CostDay, Status) =
        (regNo, make, odometer, costKm, type, costDay, status);

}
