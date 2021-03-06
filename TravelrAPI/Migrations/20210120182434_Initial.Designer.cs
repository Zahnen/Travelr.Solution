﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travelr.Models;

namespace TravelrApi.Migrations
{
    [DbContext(typeof(TravelrContext))]
    [Migration("20210120182434_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Travelr.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<int>("Rating");

                    b.Property<string>("Review")
                        .IsRequired();

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            CityName = "Bali",
                            Country = "Indonesia",
                            Rating = 5,
                            Review = "The best place I've ever been!"
                        },
                        new
                        {
                            DestinationId = 2,
                            CityName = "Austin, TX",
                            Country = "United States",
                            Rating = 4,
                            Review = "Great restaurants and shopping."
                        },
                        new
                        {
                            DestinationId = 3,
                            CityName = "San Francisco, CA",
                            Country = "United States",
                            Rating = 5,
                            Review = "Such a great city!"
                        },
                        new
                        {
                            DestinationId = 4,
                            CityName = "Seoul",
                            Country = "South Korea",
                            Rating = 5,
                            Review = "We had the time of our lives here."
                        },
                        new
                        {
                            DestinationId = 5,
                            CityName = "Portland, OR",
                            Country = "United States",
                            Rating = 5,
                            Review = "Beautiful, but wet."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
