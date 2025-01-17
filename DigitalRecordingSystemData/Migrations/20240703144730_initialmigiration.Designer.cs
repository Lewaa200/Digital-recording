﻿// <auto-generated />
using System;
using DigitalRecordingSystemData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DigitalRecordingSystemData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240703144730_initialmigiration")]
    partial class initialmigiration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DigitalRecordingSystemData.Models.DigitalRecordingModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NFC")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.ToTable("DigitalRecordings");
                });
#pragma warning restore 612, 618
        }
    }
}
