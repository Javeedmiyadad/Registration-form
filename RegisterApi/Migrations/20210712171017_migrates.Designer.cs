﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegisterApi.Properties.Models;

namespace RegisterApi.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20210712171017_migrates")]
    partial class migrates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RegisterApi.Properties.Models.Departments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .HasColumnType("text");

                    b.Property<string>("deptName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("department");
                });

            modelBuilder.Entity("RegisterApi.Properties.Models.Designation", b =>
                {
                    b.Property<int>("desId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("departmentsid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("desId");

                    b.HasIndex("departmentsid");

                    b.ToTable("designation");
                });

            modelBuilder.Entity("RegisterApi.Properties.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("DOJ")
                        .HasColumnType("text");

                    b.Property<int>("departmentsid")
                        .HasColumnType("int");

                    b.Property<int>("designationdesId")
                        .HasColumnType("int");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RegisterApi.Properties.Models.Designation", b =>
                {
                    b.HasOne("RegisterApi.Properties.Models.Departments", "departments")
                        .WithMany("designation")
                        .HasForeignKey("departmentsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
