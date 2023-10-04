using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _people = new();
    readonly List<IVehicle> _vehicles = new();
    readonly List<IBooking> _bookings = new();

    public CollectionData() => SeedData();

    void SeedData()
    {
        _people.Add(new Customer("12345", "Doe", "John"));
        _people.Add(new Customer("98765", "Doe", "Jane"));
        _vehicles.Add(new Car("ABC123", "Volvo", 10000, 1, VehicleTypes.Combi, 200));
        _vehicles.Add(new Car("DEF456", "Saab", 20000, 1, VehicleTypes.Sedan, 100));
        _vehicles.Add(new Car("GHI789", "Tesla", 1000, 3, VehicleTypes.Sedan, 100, VehicleStatuses.Booked));
        _vehicles.Add(new Car("JKL012", "Jeep", 5000, 1.5, VehicleTypes.Van, 300));
        _vehicles.Add(new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle, 50));

        var customer1 = (Customer)_people.Single(c => c.SSN.Equals("12345"));
        _bookings.Add(new Booking("GHI789", customer1, 1000, DateTime.Today, VehicleStatuses.Booked));

        var customer2 = (Customer)_people.Single(c => c.SSN.Equals("98765"));
        _bookings.Add(new Booking("JKL012", customer2, 5000, 5000, DateTime.Today,
            DateTime.Today, VehicleStatuses.Available, _vehicles[3]));
    }

    public IEnumerable<IPerson> GetPeople() => _people;

    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _vehicles;

    public IEnumerable<IBooking> GetBookings() => _bookings;
}