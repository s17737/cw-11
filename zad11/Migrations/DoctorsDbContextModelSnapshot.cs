﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zad11.Models;

namespace zad11.Migrations
{
    [DbContext(typeof(DoctorsDbContext))]
    partial class DoctorsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("zad11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "1@gmail.com",
                            FirstName = "1",
                            LastName = "1"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "2@gmail.com",
                            FirstName = "2",
                            LastName = "2"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "3@gmail.com",
                            FirstName = "3",
                            LastName = "3"
                        });
                });

            modelBuilder.Entity("zad11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "1",
                            Name = "1",
                            Type = "1"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "2",
                            Name = "2",
                            Type = "2"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "3",
                            Name = "3",
                            Type = "3"
                        });
                });

            modelBuilder.Entity("zad11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(2020, 6, 21, 20, 22, 41, 585, DateTimeKind.Local).AddTicks(5110),
                            FirstName = "1",
                            LastName = "1"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(2020, 6, 21, 20, 22, 41, 585, DateTimeKind.Local).AddTicks(5110),
                            FirstName = "2",
                            LastName = "2"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateTime(2020, 6, 21, 20, 22, 41, 585, DateTimeKind.Local).AddTicks(5110),
                            FirstName = "3",
                            LastName = "3"
                        });
                });

            modelBuilder.Entity("zad11.Models.Presciption", b =>
                {
                    b.Property<int>("IdPresciption")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPresciption");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Presciptions");

                    b.HasData(
                        new
                        {
                            IdPresciption = 1,
                            Date = new DateTime(2020, 6, 21, 20, 22, 41, 577, DateTimeKind.Local).AddTicks(5105),
                            DueDate = new DateTime(2020, 8, 10, 20, 22, 41, 582, DateTimeKind.Local).AddTicks(5108),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPresciption = 2,
                            Date = new DateTime(2020, 6, 21, 20, 22, 41, 583, DateTimeKind.Local).AddTicks(5109),
                            DueDate = new DateTime(2020, 8, 10, 20, 22, 41, 583, DateTimeKind.Local).AddTicks(5109),
                            IdDoctor = 2,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPresciption = 3,
                            Date = new DateTime(2020, 6, 21, 20, 22, 41, 583, DateTimeKind.Local).AddTicks(5109),
                            DueDate = new DateTime(2020, 8, 10, 20, 22, 41, 583, DateTimeKind.Local).AddTicks(5109),
                            IdDoctor = 3,
                            IdPatient = 3
                        });
                });

            modelBuilder.Entity("zad11.Models.Presciption_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPresciption")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPresciption");

                    b.HasIndex("IdPresciption");

                    b.ToTable("Presciption_Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPresciption = 1,
                            Details = "1"
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPresciption = 2,
                            Details = "2"
                        },
                        new
                        {
                            IdMedicament = 3,
                            IdPresciption = 3,
                            Details = "3"
                        });
                });

            modelBuilder.Entity("zad11.Models.Presciption", b =>
                {
                    b.HasOne("zad11.Models.Doctor", "Doctor")
                        .WithMany("Presciptions")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zad11.Models.Patient", "Patient")
                        .WithMany("Presciptions")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("zad11.Models.Presciption_Medicament", b =>
                {
                    b.HasOne("zad11.Models.Medicament", "Medicament")
                        .WithMany("Presciption_Medicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zad11.Models.Presciption", "Presciption")
                        .WithMany("Presciption_Medicaments")
                        .HasForeignKey("IdPresciption")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
