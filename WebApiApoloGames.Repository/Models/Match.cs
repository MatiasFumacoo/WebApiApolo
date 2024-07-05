using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Match
    {
        public int? IdMatch { get; set; }
        public int? IdBooking { get; set; }
        public int? IdTeamOne { get; set; }
        public int? IdTeamTwo { get; set; }
        public int? ScoreTeamOne { get; set; }
        public int? ScoreTeamTwo { get; set; }
    }
}
