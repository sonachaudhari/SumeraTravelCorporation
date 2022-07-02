﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SumeraTravelCorporation.Data;

#nullable disable

namespace SumeraTravelCorporation.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SumeraTravelCorporation.Data.FlightBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookingTimeStamp")
                        .HasColumnType("int");

                    b.Property<string>("CustomerContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerContactMobile")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerRefId")
                        .HasColumnType("int");

                    b.Property<int?>("FlightScheduleRefId")
                        .HasColumnType("int");

                    b.Property<string>("PassengerNameRecord")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerRefId");

                    b.HasIndex("FlightScheduleRefId");

                    b.ToTable("FlightBooking", "Transaction");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.FlightCustomerDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CustomerRefId")
                        .HasColumnType("int");

                    b.Property<int?>("FlightBookingRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerRefId");

                    b.HasIndex("FlightBookingRefId");

                    b.ToTable("FlightCustomerDetail", "Transaction");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.FlightSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArrivalDate")
                        .HasColumnType("int");

                    b.Property<int>("DepartureDate")
                        .HasColumnType("int");

                    b.Property<int?>("FlightRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlightRefId");

                    b.ToTable("FlightSchedule", "Transaction");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.HotelBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ConfirmationCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HotelRefId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HotelRefId");

                    b.ToTable("HotelBooking", "Transaction");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.HotelCustomerDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CustomerRefId")
                        .HasColumnType("int");

                    b.Property<int?>("HotelBookingRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerRefId");

                    b.HasIndex("HotelBookingRefId");

                    b.ToTable("HotelCustomerDetail", "Transaction");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Address2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Address3")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("CityRefId")
                        .HasColumnType("int");

                    b.Property<string>("Email1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Email2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Logo")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("Telephone1")
                        .HasColumnType("int");

                    b.Property<int>("Telephone2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityRefId");

                    b.ToTable("Airline", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Address2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Address3")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("CityRefId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Email1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Email2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.Property<string>("Telephone1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Telephone2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityRefId");

                    b.ToTable("Airport", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Amenities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryRefId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryRefId");

                    b.ToTable("City", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CountryCode")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Address2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Address3")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("CityRefId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("FirstName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("LastName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.Property<int>("Telephone1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityRefId");

                    b.ToTable("Customer", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Address2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Address3")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("AirlineRefId")
                        .HasColumnType("int");

                    b.Property<int?>("CityRefId")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Email1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Email2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("FromAirportRefId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.Property<int>("Telephone1")
                        .HasColumnType("int");

                    b.Property<int>("Telephone2")
                        .HasColumnType("int");

                    b.Property<int?>("ToAirportRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AirlineRefId");

                    b.HasIndex("CityRefId");

                    b.HasIndex("FromAirportRefId");

                    b.HasIndex("ToAirportRefId");

                    b.ToTable("Flight", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<int?>("CityRefId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.HasIndex("CityRefId");

                    b.ToTable("Hotel", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.HotelAmenitiesLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AmenitiesRefId")
                        .HasColumnType("int");

                    b.Property<int?>("HotelRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmenitiesRefId");

                    b.HasIndex("HotelRefId");

                    b.ToTable("HotelAmenitiesLink", "Master");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.FlightBooking", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.Customer", "CustomerRef")
                        .WithMany()
                        .HasForeignKey("CustomerRefId");

                    b.HasOne("SumeraTravelCorporation.Data.FlightSchedule", "FlightScheduleRef")
                        .WithMany()
                        .HasForeignKey("FlightScheduleRefId");

                    b.Navigation("CustomerRef");

                    b.Navigation("FlightScheduleRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.FlightCustomerDetail", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.Customer", "CustomerRef")
                        .WithMany()
                        .HasForeignKey("CustomerRefId");

                    b.HasOne("SumeraTravelCorporation.Data.FlightBooking", "FlightBookingRef")
                        .WithMany("FlightCustomerDetails")
                        .HasForeignKey("FlightBookingRefId");

                    b.Navigation("CustomerRef");

                    b.Navigation("FlightBookingRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.FlightSchedule", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.Flight", "FlightRef")
                        .WithMany()
                        .HasForeignKey("FlightRefId");

                    b.Navigation("FlightRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.HotelBooking", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.Hotel", "HotelRef")
                        .WithMany()
                        .HasForeignKey("HotelRefId");

                    b.Navigation("HotelRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.HotelCustomerDetail", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.Customer", "CustomerRef")
                        .WithMany()
                        .HasForeignKey("CustomerRefId");

                    b.HasOne("SumeraTravelCorporation.Data.HotelBooking", "HotelBookingRef")
                        .WithMany("HotelCustomerDetails")
                        .HasForeignKey("HotelBookingRefId");

                    b.Navigation("CustomerRef");

                    b.Navigation("HotelBookingRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Airline", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.City", "CityRef")
                        .WithMany()
                        .HasForeignKey("CityRefId");

                    b.Navigation("CityRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Airport", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.City", "CityRef")
                        .WithMany()
                        .HasForeignKey("CityRefId");

                    b.Navigation("CityRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.City", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.Country", "CountryRef")
                        .WithMany()
                        .HasForeignKey("CountryRefId");

                    b.Navigation("CountryRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Customer", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.City", "CityRef")
                        .WithMany()
                        .HasForeignKey("CityRefId");

                    b.Navigation("CityRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Flight", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.Airline", "AirlineRef")
                        .WithMany()
                        .HasForeignKey("AirlineRefId");

                    b.HasOne("SumeraTravelCorporation.Data.Models.City", "CityRef")
                        .WithMany()
                        .HasForeignKey("CityRefId");

                    b.HasOne("SumeraTravelCorporation.Data.Models.Airport", "AirportRef")
                        .WithMany()
                        .HasForeignKey("FromAirportRefId");

                    b.HasOne("SumeraTravelCorporation.Data.Models.Airport", "AirportRefid")
                        .WithMany()
                        .HasForeignKey("ToAirportRefId");

                    b.Navigation("AirlineRef");

                    b.Navigation("AirportRef");

                    b.Navigation("AirportRefid");

                    b.Navigation("CityRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.Hotel", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.City", "CityRef")
                        .WithMany()
                        .HasForeignKey("CityRefId");

                    b.Navigation("CityRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.Models.HotelAmenitiesLink", b =>
                {
                    b.HasOne("SumeraTravelCorporation.Data.Models.Amenities", "AmenitiesRef")
                        .WithMany()
                        .HasForeignKey("AmenitiesRefId");

                    b.HasOne("SumeraTravelCorporation.Data.Models.Hotel", "HotelRef")
                        .WithMany()
                        .HasForeignKey("HotelRefId");

                    b.Navigation("AmenitiesRef");

                    b.Navigation("HotelRef");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.FlightBooking", b =>
                {
                    b.Navigation("FlightCustomerDetails");
                });

            modelBuilder.Entity("SumeraTravelCorporation.Data.HotelBooking", b =>
                {
                    b.Navigation("HotelCustomerDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
