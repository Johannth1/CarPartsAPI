﻿// <auto-generated />
using CarPartsAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarPartsAPI.Migrations
{
    [DbContext(typeof(DelerContext))]
    partial class DelerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
