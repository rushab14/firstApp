using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EmpDAL
{
    
    public class Employee 
    {
        [Key] 
        public int Id { get; set; }         

        public string Designation { get; set; }
       

        public double Salary { get; set; }
        //[AllowNull

        public DateTime DOJ { get; set; }
        //[AllowNull]

        public bool Isactive { get; set; }
        public string Name {  get; set; }
        public string Aadhar { get; set; }
    }
    public class EMpDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=emppersondb; Trusted_Connection=true");
        }

    }

}