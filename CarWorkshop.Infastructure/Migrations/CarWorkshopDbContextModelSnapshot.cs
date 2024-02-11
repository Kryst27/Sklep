﻿// <auto-generated />
using System;
using CarWorkshop.Infastructure.Presistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarWorkshop.Infastructure.Migrations
{
    [DbContext(typeof(CarWorkshopDbContext))]
    partial class CarWorkshopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarWorkshop.Domain.Encje.CarWorkshop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncodedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("carWorkshops");
                });

            modelBuilder.Entity("CarWorkshop.Domain.Encje.CarWorkshop", b =>
                {
                    b.OwnsOne("CarWorkshop.Domain.Encje.CarWorkshopContactDetails", "ContactDetails", b1 =>
                        {
                            b1.Property<int>("CarWorkshopId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("PhoneNumber")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PostalCode")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CarWorkshopId");

                            b1.ToTable("carWorkshops");

                            b1.WithOwner()
                                .HasForeignKey("CarWorkshopId");
                        });

                    b.Navigation("ContactDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
