using System;
using System.Collections.Generic;

namespace gRPCService.Models
{
    public partial class Faculty
    {
        public decimal? Fund { get; set; }
        public int FacPk { get; set; }
        public string? Name { get; set; }
        public string? Building { get; set; }
        public int? DeanFk { get; set; }

        public virtual Teacher? DeanFkNavigation { get; set; }
    }
}
