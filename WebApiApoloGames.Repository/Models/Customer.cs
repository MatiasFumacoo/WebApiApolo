using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        public int IdPerson { get; set; }
        public int IdState { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleated { get; set; }
    }
}
