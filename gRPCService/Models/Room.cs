using System;
using System.Collections.Generic;

namespace gRPCService.Models
{
    public partial class Room
    {
        public int? Seats { get; set; }
        public int? Floor { get; set; }
        public string? Building { get; set; }
        public int RomPk { get; set; }
        public int? Number { get; set; }
    }
}
