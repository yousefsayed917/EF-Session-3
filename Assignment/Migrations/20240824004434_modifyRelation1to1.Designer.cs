﻿// <auto-generated />
using System;
using Assignment.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(Iti))]
    [Migration("20240824004434_modifyRelation1to1")]
    partial class modifyRelation1to1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"));

                    b.Property<TimeOnly>("HiringDate")
                        .HasColumnType("time");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.HasIndex("InstructorId")
                        .IsUnique()
                        .HasFilter("[InstructorId] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Assignment.Entities.InctructorCourse", b =>
                {
                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Evaluate")
                        .HasColumnType("int");

                    b.HasKey("InstructorId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("InctructorCourse");
                });

            modelBuilder.Entity("Assignment.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bouns")
                        .HasColumnType("Money");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<decimal>("HourRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("Money");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Assignment.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Assignment.Entities.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("Assignment.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar")
                        .HasColumnName("TopicName");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Assignment.Entities.Course", b =>
                {
                    b.HasOne("Assignment.Entities.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.HasOne("Assignment.Entities.Instructor", "Manager")
                        .WithOne("Manage")
                        .HasForeignKey("Assignment.Entities.Department", "InstructorId");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Assignment.Entities.InctructorCourse", b =>
                {
                    b.HasOne("Assignment.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Entities.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Assignment.Entities.Instructor", b =>
                {
                    b.HasOne("Assignment.Entities.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DeptId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assignment.Entities.Student", b =>
                {
                    b.HasOne("Assignment.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DeptId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assignment.Entities.StudentCourse", b =>
                {
                    b.HasOne("Assignment.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Assignment.Entities.Instructor", b =>
                {
                    b.Navigation("Manage")
                        .IsRequired();
                });

            modelBuilder.Entity("Assignment.Entities.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
