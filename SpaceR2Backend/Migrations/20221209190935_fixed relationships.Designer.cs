﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceR2Backend.database;

#nullable disable

namespace SpaceR2Backend.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221209190935_fixed relationships")]
    partial class fixedrelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("PD")
                .HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("SpaceR2Backend.Models.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Family")
                        .HasColumnType("TEXT");

                    b.Property<string>("Full_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("Variant")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Configuration", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Launch", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Last_updated")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LaunchServiceProviderId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MissionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PadId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RocketId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("Window_end")
                        .HasColumnType("TEXT");

                    b.Property<string>("Window_start")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LaunchServiceProviderId");

                    b.HasIndex("MissionId");

                    b.HasIndex("PadId");

                    b.HasIndex("RocketId");

                    b.HasIndex("StatusId");

                    b.ToTable("Launches", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.LaunchServiceProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LaunchServiceProvider", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("country_code")
                        .HasColumnType("TEXT");

                    b.Property<string>("map_image")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Location", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Launch_designator")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrbitId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrbitId");

                    b.ToTable("Mission", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.NasaPoDModel", b =>
                {
                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("copyright")
                        .HasColumnType("TEXT");

                    b.Property<string>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("explanation")
                        .HasColumnType("TEXT");

                    b.Property<string>("hdurl")
                        .HasColumnType("TEXT");

                    b.Property<string>("url")
                        .HasColumnType("TEXT");

                    b.HasKey("title");

                    b.ToTable("NasaPoD", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Orbit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Abbrev")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orbit", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Pad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Latitude")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Longitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("Map_image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Map_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wiki_url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Pad", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.PersonModel", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Craft")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("People", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Rocket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ConfigurationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ConfigurationId");

                    b.ToTable("Rocket", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Abbrev")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Status", "PD");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Launch", b =>
                {
                    b.HasOne("SpaceR2Backend.Models.LaunchServiceProvider", "LaunchServiceProvider")
                        .WithMany("Launches")
                        .HasForeignKey("LaunchServiceProviderId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SpaceR2Backend.Models.Mission", "Mission")
                        .WithMany("Launches")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SpaceR2Backend.Models.Pad", "Pad")
                        .WithMany("Launches")
                        .HasForeignKey("PadId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SpaceR2Backend.Models.Rocket", "Rocket")
                        .WithMany("Launches")
                        .HasForeignKey("RocketId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SpaceR2Backend.Models.Status", "Status")
                        .WithMany("Launches")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("LaunchServiceProvider");

                    b.Navigation("Mission");

                    b.Navigation("Pad");

                    b.Navigation("Rocket");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Mission", b =>
                {
                    b.HasOne("SpaceR2Backend.Models.Orbit", "Orbit")
                        .WithMany("Missions")
                        .HasForeignKey("OrbitId");

                    b.Navigation("Orbit");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Pad", b =>
                {
                    b.HasOne("SpaceR2Backend.Models.Location", "Location")
                        .WithMany("Pads")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Location");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Rocket", b =>
                {
                    b.HasOne("SpaceR2Backend.Models.Configuration", "Configuration")
                        .WithMany("Rockets")
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Configuration");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Configuration", b =>
                {
                    b.Navigation("Rockets");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.LaunchServiceProvider", b =>
                {
                    b.Navigation("Launches");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Location", b =>
                {
                    b.Navigation("Pads");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Mission", b =>
                {
                    b.Navigation("Launches");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Orbit", b =>
                {
                    b.Navigation("Missions");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Pad", b =>
                {
                    b.Navigation("Launches");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Rocket", b =>
                {
                    b.Navigation("Launches");
                });

            modelBuilder.Entity("SpaceR2Backend.Models.Status", b =>
                {
                    b.Navigation("Launches");
                });
#pragma warning restore 612, 618
        }
    }
}
