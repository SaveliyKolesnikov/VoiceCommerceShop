﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoiceCommerceShop.DAL;

#nullable disable

namespace VoiceCommerceShop.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220518121846_ExtendSeeding")]
    partial class ExtendSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CarKey = new Guid("bb640d19-77e4-4015-9286-d83eb4024736"),
                            Brand = "Toyota",
                            Color = "White",
                            Model = "Auris",
                            Price = 15000.0
                        },
                        new
                        {
                            CarKey = new Guid("b4d30da1-0297-4ca7-92d6-ea8799ade947"),
                            Brand = "Volkswagen",
                            Color = "Black",
                            Model = "Passat",
                            Price = 12000.0
                        },
                        new
                        {
                            CarKey = new Guid("d6dab40a-4568-4558-b41c-4fbfc0463fc4"),
                            Brand = "Volkswagen",
                            Color = "Red",
                            Model = "Passat",
                            Price = 15000.0
                        },
                        new
                        {
                            CarKey = new Guid("b6ea5624-87b2-4aa9-b3c0-e78e66bc5fc7"),
                            Brand = "Volkswagen",
                            Color = "Silver",
                            Model = "Passat",
                            Price = 13000.0
                        },
                        new
                        {
                            CarKey = new Guid("41d1a18e-c8eb-4dfc-b92a-ba50f389a463"),
                            Brand = "Volkswagen",
                            Color = "Yellow",
                            Model = "Beattle",
                            Price = 15000.0
                        },
                        new
                        {
                            CarKey = new Guid("d80d7b12-be9b-4c81-aefb-ee66448413ba"),
                            Brand = "Volkswagen",
                            Color = "Grey",
                            Model = "Polo",
                            Price = 6500.0
                        },
                        new
                        {
                            CarKey = new Guid("9f319617-78c0-44c0-9f14-9066a74b8cde"),
                            Brand = "Audi",
                            Color = "Silver",
                            Model = "A6",
                            Price = 20000.0
                        },
                        new
                        {
                            CarKey = new Guid("f7d9620b-52e0-4966-bf93-a86440cb6d67"),
                            Brand = "Audi",
                            Color = "Blue",
                            Model = "Q7",
                            Price = 40000.0
                        },
                        new
                        {
                            CarKey = new Guid("1a62c66a-bd85-4b58-b397-1fc88ee56303"),
                            Brand = "Mitsubishi",
                            Color = "Blue",
                            Model = "Lancer",
                            Price = 8500.0
                        },
                        new
                        {
                            CarKey = new Guid("eacd9d70-c505-4fb7-8667-75b67870ac39"),
                            Brand = "Mitsubishi",
                            Color = "Black",
                            Model = "Lancer",
                            Price = 9000.0
                        },
                        new
                        {
                            CarKey = new Guid("20403308-2a1d-4032-9843-14b526a03dfa"),
                            Brand = "Mazda",
                            Color = "Red",
                            Model = "6",
                            Price = 12000.0
                        },
                        new
                        {
                            CarKey = new Guid("081c5566-4d82-4503-be35-6abe74ca466f"),
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
