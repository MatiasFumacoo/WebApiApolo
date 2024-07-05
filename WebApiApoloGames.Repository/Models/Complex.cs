using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Complex
    {
        public int? IdComplex { get; set; }
        public int? IdOwner { get; set; }
        public int? IdState { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? Parking { get; set; }
        public bool? Grill { get; set; }
        public bool? Shower { get; set; }
        public bool? Buffet { get; set; }
        public int? DepositPercentage { get; set; }
    }
}
