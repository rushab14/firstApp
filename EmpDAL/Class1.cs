using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EmpDAL
{
    public class person
    {
        [Key]
        public int Id { get; set; }
        [AllowNull]
        public string Name { get; set; }

        [AllowNull]
        public string Aadhaar { get; set; }
        [EmailAddress]
        [AllowNull]
        public string Email { get; set; }
        [AllowNull]
        public string personGender { get; set; }
        [AllowNull]
        public DateTime DOB { get; set; }
        [AllowNull]

        public string Phone { get; set; }
        [AllowNull]
        public string Address { get; set; }


    }
    public class employee :person
    {
        public int? EmpId { get; set; }
        [AllowNull]

        public string Designation { get; set; }
        [AllowNull]

        public double Salary { get; set; }
        [AllowNull]

        public DateTime DOJ { get; set; }
        [AllowNull]

        public bool Isactive { get; set; }
    }
    public class EMpDBContext : DbContext
    {
        public DbSet<person> People { get; set; }
        public DbSet<employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=emppersondb; Trusted_Connection=true");
        }

    }

}