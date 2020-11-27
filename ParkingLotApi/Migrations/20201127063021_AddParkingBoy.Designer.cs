﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingLotApi.Repository;

namespace ParkingLotApi.Migrations
{
    [DbContext(typeof(ParkingLotContext))]
    [Migration("20201127063021_AddParkingBoy")]
    partial class AddParkingBoy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkingLotApi.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ParkingLotApi.ParkingBoy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ParkingBoys");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ParkingBoy");
                });

            modelBuilder.Entity("ParkingLotApi.SmartParkingBoy", b =>
                {
                    b.HasBaseType("ParkingLotApi.ParkingBoy");

                    b.HasDiscriminator().HasValue("SmartParkingBoy");
                });
#pragma warning restore 612, 618
        }
    }
}
