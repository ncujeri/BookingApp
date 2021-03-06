﻿// <auto-generated />
using System;
using BookingApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingApp.Migrations
{
    [DbContext(typeof(BookingContext))]
    partial class BookingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("BookingApp.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BookedTimeslotId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BookedTimeslotId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BookingApp.Models.Timeslot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<string>("Description");

                    b.Property<TimeSpan>("Duration");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.ToTable("Timeslot");
                });

            modelBuilder.Entity("BookingApp.Models.Booking", b =>
                {
                    b.HasOne("BookingApp.Models.Timeslot", "BookedTimeslot")
                        .WithMany("Bookings")
                        .HasForeignKey("BookedTimeslotId");
                });
#pragma warning restore 612, 618
        }
    }
}
