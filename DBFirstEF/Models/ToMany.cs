using System;
using System.Collections.Generic;

namespace DBFirstEF.Models
{
    public partial class ToMany
    {
        public ToMany()
        {
            Manys = new HashSet<Many>();
        }

        public int Id { get; set; }

        public virtual ICollection<Many> Manys { get; set; }
    }
}
