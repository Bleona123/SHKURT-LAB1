﻿// <auto-generated />
using System;
using DigitKosova;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DigitKosova.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DigitKosova.Models.Grading", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfessorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.HasIndex("StudentId");

                    b.ToTable("Grading");
                });

            modelBuilder.Entity("DigitKosova.Models.PersonalInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonalInfos");
                });

            modelBuilder.Entity("DigitKosova.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Literature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("News")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Topics")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("DigitKosova.Models.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mbimeri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("DigitKosova.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DigitKosova.Models.Admin", b =>
                {
                    b.HasBaseType("DigitKosova.Models.User");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("DigitKosova.Models.Parent", b =>
                {
                    b.HasBaseType("DigitKosova.Models.User");

                    b.Property<Guid?>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Parent_PersonalInfoId");

                    b.HasIndex("PersonalInfoId");

                    b.HasDiscriminator().HasValue("Parent");
                });

            modelBuilder.Entity("DigitKosova.Models.Professor", b =>
                {
                    b.HasBaseType("DigitKosova.Models.User");

                    b.Property<Guid?>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Professor_PersonalInfoId");

                    b.Property<Guid?>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("PersonalInfoId");

                    b.HasIndex("SubjectId");

                    b.HasDiscriminator().HasValue("Professor");
                });

            modelBuilder.Entity("DigitKosova.Models.Student", b =>
                {
                    b.HasBaseType("DigitKosova.Models.User");

                    b.Property<Guid?>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("PersonalInfoId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("DigitKosova.Models.Grading", b =>
                {
                    b.HasOne("DigitKosova.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId");

                    b.HasOne("DigitKosova.Models.Student", "Student")
                        .WithMany("Gradings")
                        .HasForeignKey("StudentId");

                    b.Navigation("Professor");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DigitKosova.Models.Subject", b =>
                {
                    b.HasOne("DigitKosova.Models.Parent", null)
                        .WithMany("Subjects")
                        .HasForeignKey("ParentId");

                    b.HasOne("DigitKosova.Models.Student", null)
                        .WithMany("Subjects")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DigitKosova.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DigitKosova.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigitKosova.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DigitKosova.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigitKosova.Models.Parent", b =>
                {
                    b.HasOne("DigitKosova.Models.PersonalInfo", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoId");

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("DigitKosova.Models.Professor", b =>
                {
                    b.HasOne("DigitKosova.Models.PersonalInfo", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoId");

                    b.HasOne("DigitKosova.Models.Subject", "Subject")
                        .WithMany("Professors")
                        .HasForeignKey("SubjectId");

                    b.Navigation("PersonalInfo");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("DigitKosova.Models.Student", b =>
                {
                    b.HasOne("DigitKosova.Models.PersonalInfo", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoId");

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("DigitKosova.Models.Subject", b =>
                {
                    b.Navigation("Professors");
                });

            modelBuilder.Entity("DigitKosova.Models.Parent", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("DigitKosova.Models.Student", b =>
                {
                    b.Navigation("Gradings");

                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
