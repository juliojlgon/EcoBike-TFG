﻿using System.Collections.Generic;
using Bicimad.Services.Query.Dto.Reservation;

namespace Bicimad.Services.Query.Interfaces
{
    public interface IReservationQueryService
    {
        List<ReservationDto> GetReservations(string userId);

        /// <summary>
        /// Looks into the DB for a Reservation with parameters supplied.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="stationId"></param>
        /// <param name="isBike"></param>
        /// <returns>Reservation if it exist</returns>
        ReservationDto GetReservation(string userId, string stationId, bool isBike);
    }
}