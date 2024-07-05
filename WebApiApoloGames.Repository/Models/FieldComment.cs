using System;
using System.Collections.Generic;

namespace WebApiApoloGames.Repository.Models
{
    public partial class FieldComment
    {
        public int? IdFieldComment { get; set; }
        public int? IdField { get; set; }
        public string? Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ReplyToldComment { get; set; }
    }
}
