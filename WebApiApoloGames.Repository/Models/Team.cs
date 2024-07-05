using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Team
    {
        public int? IdTeam { get; set; }
        public string? Name { get; set; }
        public string? UrlImage { get; set; }
        public int? TotalGoals { get; set; }
        public int? TotalYellowCards { get; set; }
        public int? TotalRedCards { get; set; }
    }
}
