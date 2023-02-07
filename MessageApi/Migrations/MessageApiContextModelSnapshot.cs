﻿// <auto-generated />
using System;
using MessageApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MessageApi.Migrations
{
    [DbContext(typeof(MessageApiContext))]
    partial class MessageApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageApi.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserMessage")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("BoardId");

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            BoardId = 1,
                            Date = new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserMessage = "Meow",
                            UserName = "Tiger23"
                        },
                        new
                        {
                            BoardId = 2,
                            Date = new DateTime(1000, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserMessage = "Am I holy?",
                            UserName = "Jon56"
                        },
                        new
                        {
                            BoardId = 3,
                            Date = new DateTime(2008, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserMessage = "What's the secret ingredient?",
                            UserName = "FluffyPanda"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
