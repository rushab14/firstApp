using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TESTDAL
{
    public class Many
    {
        [Key]
        public int Id { get; set; }
        public List<ToMany> toManies { get; set; }
    }
    public class ToMany
    {
        [Key]
        public int Id { get; set; } 
        public List<Many> manys { get; set; }
    }
    public class One
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
    public class ToOne
    {
        [Key]
        public int Id { get; set; }
        public One RelatedToOne { get; set; }
    }

    public class Parent {
        [Key]
        public int ParentKEY { get; set; }
        [Required]
        [StringLength(100)]
        public string name { get; set; }
        public bool isActive { get; set; }
    }
    public class Child:Parent
    {
        [NotMapped]
        public int ChildKEY {get; set; }
        public DateTime BirthDate {get; set; }
        [Range(18,100)]
        public int Age { get; set; }
        }

    public class Child2 : Parent
    {
        public string Hobbies { get; set; }

    }
    public class TestDBContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Child2> Children2 { get; set; }
        public DbSet<One> Ones { get; set; }
        public DbSet<ToOne> ToOne { get; set; }
        public DbSet<Many> Manys { get; set; }
        public DbSet<ToMany> ToManys { get; set; }







        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=testdb; Trusted_Connection=true");
        }
    }
}