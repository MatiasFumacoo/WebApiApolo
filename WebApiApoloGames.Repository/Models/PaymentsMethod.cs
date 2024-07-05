using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class PaymentsMethod
    {
        public int IdPaymentMethod { get; set; }
        public string Description { get; set; } = null!;
    }
}
