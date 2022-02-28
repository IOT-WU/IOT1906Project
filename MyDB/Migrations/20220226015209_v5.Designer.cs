﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyDB;

namespace MyDB.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20220226015209_v5")]
    partial class v5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainDTO.EFModels.Leave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Leave_AffixName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Leave_Day")
                        .HasColumnType("int");

                    b.Property<DateTime>("Leave_EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Leave_LeaveType")
                        .HasColumnType("int");

                    b.Property<string>("Leave_Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leave_Proposer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leave_Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leave_Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Leave_StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Leave_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Leave");
                });
#pragma warning restore 612, 618
        }
    }
}
