using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class FieldScore
    {
        public int? IdField { get; set; }
        public int? IdCustomer { get; set; }
        public int? Score { get; set; }
    }
}
