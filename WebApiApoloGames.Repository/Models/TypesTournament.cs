using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class TypesTournament
    {
        public int? IdTypeTournament { get; set; }
        public string? Description { get; set; }
        public string? Rules { get; set; }
        public int? MatchDuration { get; set; }
    }
}
