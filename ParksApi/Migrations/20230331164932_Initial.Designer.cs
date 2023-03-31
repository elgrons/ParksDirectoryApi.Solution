﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

#nullable disable

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    [Migration("20230331164932_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Location = "Oregon",
                            Name = "Crater Lake National Park",
                            Rating = 10,
                            Review = "Great"
                        },
                        new
                        {
                            ParkId = 2,
                            Location = "Washington",
                            Name = "Olympic National Park",
                            Rating = 8,
                            Review = "Excellent"
                        },
                        new
                        {
                            ParkId = 3,
                            Location = "Washington",
                            Name = "San Juan Island National Historic Park",
                            Rating = 7,
                            Review = "Very Good"
                        },
                        new
                        {
                            ParkId = 4,
                            Location = "Florida",
                            Name = "Everglades National Park",
                            Rating = 8,
                            Review = "Awesome, but hot"
                        },
                        new
                        {
                            ParkId = 5,
                            Location = "Utah",
                            Name = "Dead Horse Point State Park",
                            Rating = 8,
                            Review = "Nice"
                        },
                        new
                        {
                            ParkId = 6,
                            Location = "Alaska",
                            Name = "Chugach State Park",
                            Rating = 6,
                            Review = "Pretty"
                        },
                        new
                        {
                            ParkId = 7,
                            Location = "Florida",
                            Name = "Canaveral National Seashore",
                            Rating = 6,
                            Review = "Pretty"
                        },
                        new
                        {
                            ParkId = 8,
                            Location = "Nevada",
                            Name = "Valley of Fire State Park",
                            Rating = 8,
                            Review = "Gorgeous, but warm during the day and cold at night"
                        },
                        new
                        {
                            ParkId = 9,
                            Location = "Minnesota",
                            Name = "Voyageurs National Park",
                            Rating = 6,
                            Review = "Remote and low average visitor count"
                        },
                        new
                        {
                            ParkId = 10,
                            Location = "Utah",
                            Name = "Bryce Canyon National Park",
                            Rating = 1,
                            Review = "Too orange, too spiky"
                        },
                        new
                        {
                            ParkId = 11,
                            Location = "Hawaii",
                            Name = "Haleakalā National Park",
                            Rating = 10,
                            Review = "Perfect"
                        },
                        new
                        {
                            ParkId = 12,
                            Location = "Wyoming",
                            Name = "Yellowstone National Park",
                            Rating = 9,
                            Review = "Great geyser!"
                        },
                        new
                        {
                            ParkId = 13,
                            Location = "Arizona",
                            Name = "Saguaro National Park",
                            Rating = 8,
                            Review = "Lots of cacti!"
                        },
                        new
                        {
                            ParkId = 14,
                            Location = "Tennessee",
                            Name = "Great Smoky Mountains National Park",
                            Rating = 2,
                            Review = "Nothing specific to do"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
