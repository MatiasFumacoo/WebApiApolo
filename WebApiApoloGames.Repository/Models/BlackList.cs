using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class BlackList
    {
        public int? IdBlackList { get; set; }
        public int? IdCustomer { get; set; }
        public string? Reason { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateDeleated { get; set; }
    }
}
