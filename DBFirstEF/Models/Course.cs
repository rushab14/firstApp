using System;
using System.Collections.Generic;

namespace DBFirstEF.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public int? StudentId { get; set; }

        public virtual Student? Student { get; set; }
    }
}
