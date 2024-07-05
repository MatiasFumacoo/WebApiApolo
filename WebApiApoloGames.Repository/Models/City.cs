using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class City
    {
        public int IdCity { get; set; }
        public int IdProvince { get; set; }
        public string Description { get; set; } = null!;
    }
}
