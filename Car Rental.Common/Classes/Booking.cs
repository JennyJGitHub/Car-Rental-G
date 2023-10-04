using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
    public class Booking : IBooking
    {
        public string RegNo { get; init; }
        public Customer Customer { get; init; }
        public double KmRented { get; init; }
        public double? KmReturned { get; set; } = null;
        public DateTime Rented { get; init; }
        public DateTime? Returned { get; set; } = null;
        public double? Cost { get; set; } = null;
        public VehicleStatuses Status { get; set; }

        //public Booking (string regNo, Customer customer, double kmRented, double kmReturned,
        //    DateTime rented, DateTime returned, double cost, VehicleStatuses status) =>
        //    (RegNo, Customer, KmRented, KmReturned, Rented, Returned, Cost, Status) =
        //    (regNo, customer, kmRented, kmReturned, rented, returned, cost, status);

        public Booking(string regNo, Customer customer, double kmRented, double kmReturned,
            DateTime rented, DateTime returned, VehicleStatuses status, IVehicle vehicle)
        {
            RegNo = regNo;
            Customer = customer;
            KmRented = kmRented;
            KmReturned = kmReturned;
            Rented = rented;
            Returned = returned;
            Status = status;
            CalculateCost(vehicle);
        }

        public Booking(string regNo, Customer customer, double kmRented,
            DateTime rented, VehicleStatuses status) =>
            (RegNo, Customer, KmRented, Rented, Status) =
            (regNo, customer, kmRented, rented, status);

        void CalculateCost(IVehicle vehicle)
        {
            var km = KmReturned - vehicle.Odometer;
            var days = (DateTime.Today - Rented).Days;
            if (days <= 0) days = 1;
            Cost = (days * vehicle.CostDay) + km * vehicle.CostKm;
        }
    }
}
