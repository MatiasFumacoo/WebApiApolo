using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Booking
    {
        public int? IdBooking { get; set; }
        public int? IdComplex { get; set; }
        public int? IdField { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdTournament { get; set; }
        public DateTime? Date { get; set; }
    }
}
