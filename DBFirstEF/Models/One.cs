using System;
using System.Collections.Generic;

namespace DBFirstEF.Models
{
    public partial class One
    {
        public One()
        {
            ToOnes = new HashSet<ToOne>();
        }

        public int Id { get; set; }
        public string Value { get; set; } = null!;

        public virtual ICollection<ToOne> ToOnes { get; set; }
    }
}
