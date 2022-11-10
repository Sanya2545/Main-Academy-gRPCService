using System;
using System.Collections.Generic;

namespace gRPCService.Models
{
    public partial class Department
    {
        public Department()
        {
            Sgroups = new HashSet<Sgroup>();
            Teachers = new HashSet<Teacher>();
        }

        public int DepPk { get; set; }
        public int? FacFk { get; set; }
        public string? Name { get; set; }
        public string? Building { get; set; }
        public int? HeadFk { get; set; }
        public double? Fund { get; set; }

        public virtual Teacher? HeadFkNavigation { get; set; }
        public virtual ICollection<Sgroup> Sgroups { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
