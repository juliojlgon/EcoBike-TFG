﻿

using System.Collections.Generic;
using System.Linq;
using Bicimad.Core;
using Bicimad.Core.DomainObjects;
using Bicimad.Helpers;
using Bicimad.Services.Command.Commands;
using Bicimad.Services.Command.Interface;

namespace Bicimad.Services.Command
{
    public class ReservationCommandService: BaseCommandService, IReservationCommandService
    {
        public ReservationCommandService(IRepository repository) : base(repository)
        {
        }

        public CommandResult BookItem(string userId, string stationId, string itemId, bool isBike)
        {

            var commandResult = new CommandResult();


            if (Repository.UserHistories.Any(us => us.UserId == userId && !us.Finished && isBike))
            {
                commandResult.AddValidationError("No puedes coger más de una bicicleta a la vez");
                return commandResult;
            }
            
            if (Repository.Reservations.Any(r => !r.Isbike && r.UserId == userId))
            {
                commandResult.AddValidationError("No puedes reservar más de un anclaje a la vez.");
                return commandResult;
            }
            
            if (Repository.Reservations.Any(r => r.Isbike && r.UserId == userId))
            {
                commandResult.AddValidationError("No puedes reservar más de una bicicleta a la vez.");
                return commandResult;
            }

            var station = Repository.Stations.First(s => s.Id == stationId);

            if (isBike && station.FreeBikes == 0)
            {
                commandResult.AddValidationError("No hay bicicletas disponibles en la estación seleccionada.");
                return commandResult;
            }
            var availSlots = station.BikeNum - (station.FreeBikes + station.ReservedSlots);
            if (!isBike && availSlots == 0)
            {
                commandResult.AddValidationError("No hay anclajes disponibles en la estación seleccionada.");
                return commandResult;
            }
            //TODO: Buscar si hay mas errores de validación.

            var id = GuidHelper.GenerateId();

            //Mark selected item as booked & add or delete from the station variable.
            if (isBike)
            {
                var bike = Repository.Bikes.First(b => b.Id == itemId);
                bike.IsBooked = true;
                var freeB = station.FreeBikes - 1;
                station.FreeBikes = freeB;
            }
            else
            {
                var slot = Repository.Slots.First(s => s.Id == itemId);
                slot.IsBooked = true;
                var resSlots = station.ReservedSlots + 1;
                station.ReservedSlots = resSlots;
            }


            //Add the action to the database.
            Repository.Reservations.Add(new Reservation
            {
                Id = id,
                Isbike = isBike,
                CreatedDate = DateTimeHelper.SpanishNow,
                ItemId = itemId,
                UserId = userId,
                StationId = stationId
            });

            //Commit the changes to the database.
            Repository.Commit();

            commandResult.ItemId = id;
            return commandResult;
        }

        public CommandResult RemoveReservation(string id, string stationId)
        {
            var commandResult = new CommandResult();

            var reservation = Repository.Reservations.FirstOrDefault(s => s.UserId == id && s.StationId == stationId);

            if (reservation == null)
            {
                commandResult.AddValidationError("La reserva no es válida");
                return commandResult;
            }
            
            if (reservation.Isbike)
            {
                var bike = Repository.Bikes.First(b => b.Id == reservation.ItemId);
                bike.IsBooked = false;
                Repository.Stations.First(s => s.Id == stationId).FreeBikes++;
            }
            else
            {
                var slot = Repository.Slots.First(s => s.Id == reservation.ItemId);
                slot.IsBooked = false;
                Repository.Stations.First(s => s.Id == stationId).ReservedSlots--;
            }

            Repository.Reservations.Remove(reservation);

            Repository.Commit();

            return commandResult;
        }

        public CommandResult RemoveReservations(List<string> ids)
        {
            var commandResult = new CommandResult();

            var reservations = ids.Select(id => Repository.Reservations.FirstOrDefault(r => r.UserId == id)).ToList();

            if (reservations.Any(reservation => reservation == null))
            {
                commandResult.AddValidationError("Hay reservas no válidas");
                return commandResult;
            }

            Repository.Reservations.RemoveRange(reservations);
            return commandResult ;
        }
    }
}
