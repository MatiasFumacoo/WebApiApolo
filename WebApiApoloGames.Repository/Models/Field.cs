using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Field
    {
        public int? IdField { get; set; }
        public int? IdComplex { get; set; }
        public int? IdSport { get; set; }
        public int? IdSurface { get; set; }
        public int? IdState { get; set; }
        public string? Name { get; set; }
        public int? Size { get; set; }
        public bool? Indoor { get; set; }
        public bool? Light { get; set; }
    }
}
