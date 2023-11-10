using System;
using System.Collections.Generic;

namespace DBFirstEF.Models
{
    public partial class Many
    {
        public Many()
        {
            ToManies = new HashSet<ToMany>();
        }

        public int Id { get; set; }

        public virtual ICollection<ToMany> ToManies { get; set; }
    }
}
