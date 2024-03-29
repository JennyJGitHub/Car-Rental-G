﻿using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<IPerson> GetCustomers() => _db.GetPeople();

    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _db.GetVehicles();

    public IEnumerable<IBooking> GetBookings() => _db.GetBookings();
}
