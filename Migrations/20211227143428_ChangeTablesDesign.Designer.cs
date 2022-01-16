﻿// <auto-generated />
using System;
using CarEngines;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarEngines.Migrations
{
    [DbContext(typeof(EngineContext))]
    [Migration("20211227143428_ChangeTablesDesign")]
    partial class ChangeTablesDesign
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarEngines.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Acceleration_0_100")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("AveragePrice_PLN")
                        .HasColumnType("int");

                    b.Property<string>("Car_Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EndOfProduction")
                        .HasColumnType("int");

                    b.Property<int?>("EngineId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Fuel_Consumption")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("MaxSpeed_KM_H")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtomotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Power_HP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StartOfProduction")
                        .HasColumnType("int");

                    b.Property<string>("Torque_Nm")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.HasIndex("EngineId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarEngines.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity_ccm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("CarEngines.Car", b =>
                {
                    b.HasOne("CarEngines.Engine", "Engine")
                        .WithMany("CarsList")
                        .HasForeignKey("EngineId");

                    b.Navigation("Engine");
                });

            modelBuilder.Entity("CarEngines.Engine", b =>
                {
                    b.Navigation("CarsList");
                });
#pragma warning restore 612, 618
        }
    }
}
