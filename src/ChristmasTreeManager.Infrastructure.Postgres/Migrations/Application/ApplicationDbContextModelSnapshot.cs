﻿// <auto-generated />
using System;
using ChristmasTreeManager.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChristmasTreeManager.Infrastructure.Postgres.Migrations.Application
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.CollectionTourEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Driver")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Staff")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Vehicle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CollectionTours", t =>
                        {
                            t.HasTrigger("CollectionTours_Trigger");
                        });
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.DistributionTourEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Staff")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DistributionTours", t =>
                        {
                            t.HasTrigger("DistributionTours_Trigger");
                        });
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.RegistrationEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Donation")
                        .HasColumnType("double precision");

                    b.Property<long>("Housenumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RegistrationPointId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StreetId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("TreeCount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationPointId");

                    b.HasIndex("StreetId");

                    b.ToTable("Registrations", t =>
                        {
                            t.HasTrigger("Registrations_Trigger");
                        });
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.RegistrationPointEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RegistrationPoints", t =>
                        {
                            t.HasTrigger("RegistrationPoints_Trigger");
                        });
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.StreetEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CollectionTourId")
                        .HasColumnType("text");

                    b.Property<long>("CollectionTourOrderNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DistributionTourId")
                        .HasColumnType("text");

                    b.Property<long>("DistributionTourOrderNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("HighestHouseNumber")
                        .HasColumnType("bigint");

                    b.Property<long>("LowestHouseNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CollectionTourId");

                    b.HasIndex("DistributionTourId");

                    b.ToTable("Streets", t =>
                        {
                            t.HasTrigger("Streets_Trigger");
                        });
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.RegistrationEntity", b =>
                {
                    b.HasOne("ChristmasTreeManager.Data.Application.RegistrationPointEntity", "RegistrationPoint")
                        .WithMany("Registrations")
                        .HasForeignKey("RegistrationPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChristmasTreeManager.Data.Application.StreetEntity", "Street")
                        .WithMany("Registrations")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegistrationPoint");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.StreetEntity", b =>
                {
                    b.HasOne("ChristmasTreeManager.Data.Application.CollectionTourEntity", "CollectionTour")
                        .WithMany("Streets")
                        .HasForeignKey("CollectionTourId");

                    b.HasOne("ChristmasTreeManager.Data.Application.DistributionTourEntity", "DistributionTour")
                        .WithMany("Streets")
                        .HasForeignKey("DistributionTourId");

                    b.Navigation("CollectionTour");

                    b.Navigation("DistributionTour");
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.CollectionTourEntity", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.DistributionTourEntity", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.RegistrationPointEntity", b =>
                {
                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("ChristmasTreeManager.Data.Application.StreetEntity", b =>
                {
                    b.Navigation("Registrations");
                });
#pragma warning restore 612, 618
        }
    }
}
