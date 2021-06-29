﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesDB;

namespace MoviesDB.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210105133802_migration3")]
    partial class migration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MoviesDB.Hall", b =>
                {
                    b.Property<int>("HallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Hall_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Place_count")
                        .HasColumnType("int");

                    b.HasKey("HallId");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("MoviesDB.Hall_Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "HallId");

                    b.HasIndex("HallId");

                    b.ToTable("Hall_Movie");
                });

            modelBuilder.Entity("MoviesDB.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Movie_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("start_datetime")
                        .HasColumnType("datetime2");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoviesDB.Hall_Movie", b =>
                {
                    b.HasOne("MoviesDB.Hall", "Hall")
                        .WithMany("Hall_Movies")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesDB.Movie", "Movie")
                        .WithMany("Hall_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MoviesDB.Hall", b =>
                {
                    b.Navigation("Hall_Movies");
                });

            modelBuilder.Entity("MoviesDB.Movie", b =>
                {
                    b.Navigation("Hall_Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
