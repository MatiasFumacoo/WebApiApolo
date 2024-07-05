using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class ComplexSocialNetwork
    {
        public int? IdComplexSocialNetwork { get; set; }
        public int? IdComplex { get; set; }
        public int? IdSocialNetwork { get; set; }
        public string? Url { get; set; }
    }
}
