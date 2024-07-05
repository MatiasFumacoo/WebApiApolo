using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class ComplexAddress
    {
        public int? IdComplexAddress { get; set; }
        public int? IdComplex { get; set; }
        public int? IdCity { get; set; }
        public string? Street { get; set; }
        public int? NumberStreet { get; set; }
    }
}
