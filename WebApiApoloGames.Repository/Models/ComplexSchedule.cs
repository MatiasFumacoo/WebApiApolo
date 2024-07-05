using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class ComplexSchedule
    {
        public int? IdComplexSchedule { get; set; }
        public int? IdComplex { get; set; }
        public int? IdDayTo { get; set; }
        public int? IdDayFrom { get; set; }
    }
}
