﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppdemo.Data;

namespace WebAppdemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220120105914_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppdemo.Data.CityModel", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.HasIndex("CountryID");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CountryID = 1,
                            Name = "Konohagakure, Hidden In The Leaf"
                        },
                        new
                        {
                            CityId = 2,
                            CountryID = 2,
                            Name = "Sunagakure, Hidden In The Sand"
                        });
                });

            modelBuilder.Entity("WebAppdemo.Data.CountryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "the Land of Fire"
                        },
                        new
                        {
                            Id = 2,
                            Name = "the Land of Wind"
                        });
                });

            modelBuilder.Entity("WebAppdemo.Data.PeopleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Naruto",
                            Skills = "Shadow Clones"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Name = "Sasuke",
                            Skills = "Fireball"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Name = "Gaara",
                            Skills = "Shield of Sand"
                        });
                });

            modelBuilder.Entity("WebAppdemo.Data.CityModel", b =>
                {
                    b.HasOne("WebAppdemo.Data.CountryModel", "Country")
                        .WithMany("Cyties")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppdemo.Data.PeopleModel", b =>
                {
                    b.HasOne("WebAppdemo.Data.CityModel", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
