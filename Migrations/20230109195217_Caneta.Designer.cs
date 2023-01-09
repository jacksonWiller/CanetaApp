﻿// <auto-generated />
using ConsoleDataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CanetaApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230109195217_Caneta")]
    partial class Caneta
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("CanetaApp.Caneta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Carga")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Tampada")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Canetas");
                });
#pragma warning restore 612, 618
        }
    }
}
