using System;
using System.Collections.Generic;

namespace gRPCService.Models
{
    public partial class Sgroup
    {
        public int? Course { get; set; }
        public int? Num { get; set; }
        public int? Quantity { get; set; }
        public int? Curator { get; set; }
        public int? Rating { get; set; }
        public int GrpPk { get; set; }
        public int? DepFk { get; set; }

        public virtual Department? DepFkNavigation { get; set; }
    }
}
