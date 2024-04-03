﻿// <auto-generated />
using System;
using EF_Core_Code_first.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Core_Code_first.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240403070346_AddInitial")]
    partial class AddInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Core_Code_first.Models.Courses", b =>
                {
                    b.Property<Guid>("CoursesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CoursesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoursesId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EF_Core_Code_first.Models.StudentCourses", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoursesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentsStudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "CoursesId");

                    b.HasIndex("CoursesId");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("EF_Core_Code_first.Models.Students", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF_Core_Code_first.Models.StudentCourses", b =>
                {
                    b.HasOne("EF_Core_Code_first.Models.Courses", "Courses")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Core_Code_first.Models.Students", "Students")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentsStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EF_Core_Code_first.Models.Courses", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("EF_Core_Code_first.Models.Students", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
