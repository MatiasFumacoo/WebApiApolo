using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class PlayersTeam
    {
        public int? IdPlayer { get; set; }
        public int? IdTeam { get; set; }
        public string? Name { get; set; }
        public byte[]? LastName { get; set; }
        public int? Dni { get; set; }
        public int? Age { get; set; }
        public int? Goals { get; set; }
        public int? YellowCards { get; set; }
        public int? RedCards { get; set; }
    }
}
