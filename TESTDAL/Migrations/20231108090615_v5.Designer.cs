﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TESTDAL;

#nullable disable

namespace TESTDAL.Migrations
{
    [DbContext(typeof(TestDBContext))]
    [Migration("20231108090615_v5")]
    partial class v5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TESTDAL.Parent", b =>
                {
                    b.Property<int>("ParentKEY")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParentKEY"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ParentKEY");

                    b.ToTable("Parents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Parent");
                });

            modelBuilder.Entity("TESTDAL.Child", b =>
                {
                    b.HasBaseType("TESTDAL.Parent");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Child");
                });

            modelBuilder.Entity("TESTDAL.Child2", b =>
                {
                    b.HasBaseType("TESTDAL.Parent");

                    b.Property<string>("Hobbies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Child2");
                });
#pragma warning restore 612, 618
        }
    }
}
