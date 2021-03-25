﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using uppgift1_asp.net.Data;

namespace uppgift1_asp.net.Migrations
{
    [DbContext(typeof(EventsDbContext))]
    [Migration("20210325074444_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("uppgift1_asp.net.Models.Attender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attender");
                });

            modelBuilder.Entity("uppgift1_asp.net.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttenderId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("organisation_id")
                        .HasColumnType("int");

                    b.Property<string>("place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("spots_available")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttenderId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("uppgift1_asp.net.Models.Organisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organisation");
                });

            modelBuilder.Entity("uppgift1_asp.net.Models.Event", b =>
                {
                    b.HasOne("uppgift1_asp.net.Models.Attender", null)
                        .WithMany("events")
                        .HasForeignKey("AttenderId");

                    b.HasOne("uppgift1_asp.net.Models.Organisation", null)
                        .WithMany("events")
                        .HasForeignKey("OrganisationId");
                });

            modelBuilder.Entity("uppgift1_asp.net.Models.Attender", b =>
                {
                    b.Navigation("events");
                });

            modelBuilder.Entity("uppgift1_asp.net.Models.Organisation", b =>
                {
                    b.Navigation("events");
                });
#pragma warning restore 612, 618
        }
    }
}
