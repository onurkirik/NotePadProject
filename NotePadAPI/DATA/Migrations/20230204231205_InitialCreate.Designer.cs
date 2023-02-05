﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotePadAPI.DATA;

#nullable disable

namespace NotePadAPI.DATA.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230204231205_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NotePadAPI.DATA.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "1.Bot \n 2. Kot",
                            CreationTime = new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9578),
                            Title = "Alınacaklar",
                            UpdateTime = new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9591)
                        },
                        new
                        {
                            Id = 2,
                            Content = "1.Ye \n 2. Dua et \n 3. Sev",
                            CreationTime = new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9594),
                            Title = "Görevler",
                            UpdateTime = new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9595)
                        },
                        new
                        {
                            Id = 3,
                            Content = "1. Muş \n 2. Van \n 3. Of",
                            CreationTime = new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9596),
                            Title = "Gez & Gör",
                            UpdateTime = new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9597)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
