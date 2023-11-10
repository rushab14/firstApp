using System;
using System.Collections.Generic;

namespace DBFirstEF.Models
{
    public partial class Company
    {
        public Company()
        {
            Students = new HashSet<Student>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
