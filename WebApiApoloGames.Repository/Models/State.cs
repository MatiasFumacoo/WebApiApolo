using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class State
    {
        public int IdState { get; set; }
        public string Description { get; set; } = null!;
    }
}
