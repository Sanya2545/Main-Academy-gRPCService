using System;
using System.Collections.Generic;

namespace gRPCService.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Departments = new HashSet<Department>();
            Faculties = new HashSet<Faculty>();
        }

        public string? Post { get; set; }
        public string? Tel { get; set; }
        public DateTime? Hiredate { get; set; }
        public int? Salary { get; set; }
        public int TchPk { get; set; }
        public int? DepFk { get; set; }
        public string? Name { get; set; }
        public int? Commission { get; set; }

        public virtual Department? DepFkNavigation { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
