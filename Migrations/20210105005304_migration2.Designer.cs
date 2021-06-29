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
    [Migration("20210105005304_migration2")]
    partial class migration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("HallMovie", b =>
                {
                    b.Property<int>("HallsHallId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesMovieId")
                        .HasColumnType("int");

                    b.HasKey("HallsHallId", "MoviesMovieId");

                    b.HasIndex("MoviesMovieId");

                    b.ToTable("HallMovie");
                });

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
                    b.Property<int>("Hall_MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("HallId")
                        .HasColumnType("int");

                    b.Property<int>("HallsHallId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesMovieId")
                        .HasColumnType("int");

                    b.HasKey("Hall_MovieId");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.ToTable("HallsMovies");
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

            modelBuilder.Entity("HallMovie", b =>
                {
                    b.HasOne("MoviesDB.Hall", null)
                        .WithMany()
                        .HasForeignKey("HallsHallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesDB.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviesDB.Hall_Movie", b =>
                {
                    b.HasOne("MoviesDB.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallId");

                    b.HasOne("MoviesDB.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");

                    b.Navigation("Hall");

                    b.Navigation("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
