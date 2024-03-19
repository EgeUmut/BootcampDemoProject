﻿// <auto-generated />
using System;
using DataAccess.Concretes.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(TobetoBootCampProjectContext))]
    [Migration("20240309101830_9MartSabah")]
    partial class _9MartSabah
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Utilities.Security.Entities.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims", (string)null);
                });

            modelBuilder.Entity("Core.Utilities.Security.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("NationalIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NationalIdentity");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordSalt");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Core.Utilities.Security.Entities.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int")
                        .HasColumnName("OperationClaimId");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicantId")
                        .HasColumnType("int")
                        .HasColumnName("ApplicantId");

                    b.Property<int>("ApplicationStateId")
                        .HasColumnType("int")
                        .HasColumnName("ApplicationStateId");

                    b.Property<int>("BootcampId")
                        .HasColumnType("int")
                        .HasColumnName("BootcampId");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeleteDate");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("ApplicationStateId");

                    b.HasIndex("BootcampId");

                    b.ToTable("Applications", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.ApplicationState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeleteDate");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("ApplicationStates", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.BlackList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicantId")
                        .HasColumnType("int")
                        .HasColumnName("ApplicantId");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeleteDate");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Reason");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId")
                        .IsUnique();

                    b.ToTable("BlackLists", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Bootcamp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BootcampStateId")
                        .HasColumnType("int")
                        .HasColumnName("BootcampStateId");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeleteDate");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EndDate");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int")
                        .HasColumnName("InstructorId");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartDate");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("BootcampStateId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Bootcamps", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.BootcampState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeleteDate");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("BootcampStates", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Applicant", b =>
                {
                    b.HasBaseType("Core.Utilities.Security.Entities.User");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("About");

                    b.ToTable("Applicants", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Employee", b =>
                {
                    b.HasBaseType("Core.Utilities.Security.Entities.User");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Position");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("Entities.Concretes.Instructor", b =>
                {
                    b.HasBaseType("Core.Utilities.Security.Entities.User");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CompanyName");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("Core.Utilities.Security.Entities.UserOperationClaim", b =>
                {
                    b.HasOne("Core.Utilities.Security.Entities.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.Utilities.Security.Entities.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concretes.Application", b =>
                {
                    b.HasOne("Entities.Concretes.Applicant", "Applicant")
                        .WithMany("Applications")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concretes.ApplicationState", "ApplicationState")
                        .WithMany()
                        .HasForeignKey("ApplicationStateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concretes.Bootcamp", "Bootcamp")
                        .WithMany("Applications")
                        .HasForeignKey("BootcampId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("ApplicationState");

                    b.Navigation("Bootcamp");
                });

            modelBuilder.Entity("Entities.Concretes.BlackList", b =>
                {
                    b.HasOne("Entities.Concretes.Applicant", "Applicant")
                        .WithOne("BlackList")
                        .HasForeignKey("Entities.Concretes.BlackList", "ApplicantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Applicant");
                });

            modelBuilder.Entity("Entities.Concretes.Bootcamp", b =>
                {
                    b.HasOne("Entities.Concretes.BootcampState", "BootcampState")
                        .WithMany()
                        .HasForeignKey("BootcampStateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concretes.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BootcampState");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Entities.Concretes.Applicant", b =>
                {
                    b.HasOne("Core.Utilities.Security.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concretes.Applicant", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concretes.Employee", b =>
                {
                    b.HasOne("Core.Utilities.Security.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concretes.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concretes.Instructor", b =>
                {
                    b.HasOne("Core.Utilities.Security.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concretes.Instructor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Utilities.Security.Entities.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Core.Utilities.Security.Entities.User", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concretes.Bootcamp", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("Entities.Concretes.Applicant", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("BlackList")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}