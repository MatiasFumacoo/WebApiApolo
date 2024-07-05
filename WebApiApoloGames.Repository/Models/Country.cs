using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Country
    {
        public int IdCountry { get; set; }
        public string Description { get; set; } = null!;
    }
}
