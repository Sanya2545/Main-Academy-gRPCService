using System;
using System.Collections.Generic;

namespace gRPCService.Models
{
    public partial class Lecture
    {
        public string? Type { get; set; }
        public int? Week { get; set; }
        public int? Lesson { get; set; }
        public int? TchFk { get; set; }
        public int? GrpFk { get; set; }
        public int? SbjFk { get; set; }
        public int? RomFk { get; set; }
        public string? Day { get; set; }

        public virtual Sgroup? GrpFkNavigation { get; set; }
        public virtual Room? RomFkNavigation { get; set; }
        public virtual Subject? SbjFkNavigation { get; set; }
        public virtual Teacher? TchFkNavigation { get; set; }
    }
}
