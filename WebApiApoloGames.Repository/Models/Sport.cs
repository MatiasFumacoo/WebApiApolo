using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Sport
    {
        public int IdSport { get; set; }
        public string Description { get; set; } = null!;
    }
}
