using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Tournament
    {
        public int? IdTournament { get; set; }
        public int? IdComplex { get; set; }
        public int? IdTypeTournament { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? NumberTeams { get; set; }
        public int? Price { get; set; }
        public DateTime? DateInscriptionTo { get; set; }
        public DateTime? DateInscriptionFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? DateFrom { get; set; }
    }
}
