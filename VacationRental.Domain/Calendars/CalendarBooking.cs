﻿using VacationRental.Core.Domain;

namespace VacationRental.Domain.Calendars
{
    public sealed class CalendarBooking : ValueObject
    {
        public int BookingId { get; set; }
    }
}