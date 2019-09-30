﻿// <auto-generated />
using System;
using AirPlaneGol.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirPlaneGol.Migrations
{
    [DbContext(typeof(AirPlaneContex))]
    [Migration("db_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirPlaneGol.Models.AirPlane", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dtaCriacao");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("qtdPassageiros");

                    b.HasKey("id");

                    b.ToTable("airPlane");
                });
#pragma warning restore 612, 618
        }
    }
}
