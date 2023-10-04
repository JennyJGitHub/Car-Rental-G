using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public string RegNo { get; init; }
    public Customer Customer { get; init; }
    public double KmRented { get; init; }
    public double? KmReturned { get; set; }
    public DateTime Rented { get; init; }
    public DateTime? Returned { get; set; }
    public double? Cost { get; set; }
    public VehicleStatuses Status { get; set; }
}
