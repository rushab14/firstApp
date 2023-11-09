using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LabDal
{
    public class Student 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth {  get; set; } 

        public List<Courses> Courses { get; set; }
        public Company CompanyName {  get; set; }
    }

    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Student> studens { get; set; }
    }

    public class Company
    {
        [Key]
        public int CompanyId { get; set; } 
        public string CompanyName { get; set;}
    }
    public class TestDBContext : DbContext
    {
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses{ get; set; }
        public DbSet<Company> Companies { get; set; }







        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=studentcoursesdb; Trusted_Connection=true");
        }
    }
}