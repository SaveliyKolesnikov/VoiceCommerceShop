﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoiceCommerceShop.DAL;

#nullable disable

namespace VoiceCommerceShop.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VoiceCommerceShop.Domain.Car", b =>
                {
                    b.Property<Guid>("CarKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("CarKey");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarKey = new Guid("57968317-8e9d-40db-a15c-82456b9d3e7c"),
                            Brand = "Toyota",
                            Color = "White",
                            Model = "Auris",
                            Price = 15000.0
                        },
                        new
                        {
                            CarKey = new Guid("8a436108-ad33-465a-8543-c1a512e39eff"),
                            Brand = "Volkswagen",
                            Color = "Black",
                            Model = "Passat",
                            Price = 12000.0
                        },
                        new
                        {
                            CarKey = new Guid("582085c8-00dc-496f-b8df-1cfbf4777b40"),
                            Brand = "Mitsubishi",
                            Color = "Blue",
                            Model = "Lancer",
                            Price = 8500.0
                        },
                        new
                        {
                            CarKey = new Guid("7fa5d45f-fef0-4559-ad42-e83257ad57e5"),
                            Brand = "Volkswagen",
                            Color = "Grey",
                            Model = "Polo",
                            Price = 6500.0
                        },
                        new
                        {
                            CarKey = new Guid("006efc50-b50d-4b90-8652-e1d8b37a044e"),
                            Brand = "Mazda",
                            Color = "Black",
                            Model = "3",
                            Price = 6300.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
