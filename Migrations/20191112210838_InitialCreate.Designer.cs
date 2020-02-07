﻿// <auto-generated />
using CarPartsAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarPartsAPI.Migrations
{
    [DbContext(typeof(DelerContext))]
    [Migration("20191112210838_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("CarPartsAPI.Models.Deler", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Antall")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DelerNummer")
                        .HasColumnType("INTEGER");

                    b.Property<char>("Hylle")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rad")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Deler");
                });
#pragma warning restore 612, 618
        }
    }
}
