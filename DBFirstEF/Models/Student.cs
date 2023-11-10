using System;
using System.Collections.Generic;

namespace DBFirstEF.Models
{
    public partial class Student
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public int CompanyNameCompanyId { get; set; }

        public virtual Company CompanyNameCompany { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; }
    }
}
