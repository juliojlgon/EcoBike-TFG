﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bicimad.Web.Models.Station
{
    public class MapReservStationModel
    {
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public int BikeNum { get; set; }

        public int FreeBikes { get; set; }

        public string StationName { get; set; }

        public string FriendlyUrlStationName { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Metro { get; set; }

        public string Bus { get; set; }

        public int ReservedSlots { get; set; }

        public bool IsBikeBooked { get; set; }

        public bool IsSlotBooked { get; set; }

        public int AvailSlots { get; set; }

    }
}