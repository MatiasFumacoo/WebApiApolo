using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class ComplexComment
    {
        public int? IdComplexComment { get; set; }
        public int? IdComplex { get; set; }
        public int? IdCustomer { get; set; }
        public string? Comment { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
