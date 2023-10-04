using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IVehicle
{
    public string RegNo { get; init; }
    public string Make { get; init; }
    public double Odometer { get; init; }
    public double CostKm { get; init; }
    public VehicleTypes Type { get; init; }
    public double CostDay { get; init; }
    public VehicleStatuses Status { get; init; } 
}
