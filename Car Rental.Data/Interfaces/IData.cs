﻿using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Interfaces;

public interface IData
{
    IEnumerable<IPerson> GetPeople();

    IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default);

    IEnumerable<IBooking> GetBookings();
}
