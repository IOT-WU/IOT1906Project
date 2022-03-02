﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyDB;

namespace MyDB.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20220302031531_v6.1")]
    partial class v61
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainDTO.EFModels.Procurement", b =>
                {
                    b.Property<int>("Procurement_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Procurement_Agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procurement_Applicant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procurement_ApplyDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procurement_ApplyTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procurement_HandlingDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procurement_HandlingTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procurement_Use")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Procurement_Id");

                    b.ToTable("Procurement");
                });
#pragma warning restore 612, 618
        }
    }
}
