﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using My_bookStore.Data;

#nullable disable

namespace My_bookStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241030104122_SeedCategoryTable")]
    partial class SeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("My_bookStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Displayorder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Displayorder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Displayorder = 2,
                            Name = "Sci-fi"
                        },
                        new
                        {
                            Id = 3,
                            Displayorder = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 4,
                            Displayorder = 4,
                            Name = "Romance"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
