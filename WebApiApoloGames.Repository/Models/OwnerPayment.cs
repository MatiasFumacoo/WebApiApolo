using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class OwnerPayment
    {
        public int IdOwnerPayment { get; set; }
        public int IdOwner { get; set; }
        public int IdPaymentMethod { get; set; }
        public int? Cbu { get; set; }
        public string? Alias { get; set; }
    }
}
