using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class Person
    {
        public int IdPerson { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Idtype { get; set; } = null!;
        public int NumberId { get; set; }
        public string? Email { get; set; }
        public string? User { get; set; }
        public string? Password { get; set; }
    }
}
