using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirstEF.Models
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext()
        {
        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Many> Manys { get; set; } = null!;
        public virtual DbSet<One> Ones { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<ToMany> ToManys { get; set; } = null!;
        public virtual DbSet<ToOne> ToOnes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestDb;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => e.StudentId, "IX_Courses_StudentId");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.StudentId);
            });

            modelBuilder.Entity<Many>(entity =>
            {
                entity.HasMany(d => d.ToManies)
                    .WithMany(p => p.Manys)
                    .UsingEntity<Dictionary<string, object>>(
                        "ManyToMany",
                        l => l.HasOne<ToMany>().WithMany().HasForeignKey("ToManiesId"),
                        r => r.HasOne<Many>().WithMany().HasForeignKey("ManysId"),
                        j =>
                        {
                            j.HasKey("ManysId", "ToManiesId");

                            j.ToTable("ManyToMany");

                            j.HasIndex(new[] { "ToManiesId" }, "IX_ManyToMany_toManiesId");

                            j.IndexerProperty<int>("ManysId").HasColumnName("manysId");

                            j.IndexerProperty<int>("ToManiesId").HasColumnName("toManiesId");
                        });
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.ParentKey);

                entity.Property(e => e.ParentKey).HasColumnName("ParentKEY");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.CompanyNameCompanyId, "IX_Students_CompanyNameCompanyId");

                entity.HasOne(d => d.CompanyNameCompany)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.CompanyNameCompanyId);
            });

            modelBuilder.Entity<ToOne>(entity =>
            {
                entity.ToTable("ToOne");

                entity.HasIndex(e => e.RelatedToOneId, "IX_ToOne_RelatedToOneId");

                entity.HasOne(d => d.RelatedToOne)
                    .WithMany(p => p.ToOnes)
                    .HasForeignKey(d => d.RelatedToOneId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
