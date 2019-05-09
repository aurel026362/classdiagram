﻿// <auto-generated />
using System;
using App.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Data.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20190509155404_vv")]
    partial class vv
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("DateComment");

                    b.Property<long?>("ThemeId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Content = "Nicjdsladj sal djsa dsadsa.",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 49, DateTimeKind.Local).AddTicks(4487),
                            ThemeId = 1L,
                            UserId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            Content = "dsafdsda.",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9204),
                            ThemeId = 3L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            Content = "qewqeqewqqewq.",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9224),
                            ThemeId = 1L,
                            UserId = 4L
                        },
                        new
                        {
                            Id = 4L,
                            Content = "asdsadsa sadsadsa dsa.",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9231),
                            ThemeId = 4L,
                            UserId = 2L
                        },
                        new
                        {
                            Id = 5L,
                            Content = "zxcxzcxz zc xz cxz z.",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9238),
                            ThemeId = 1L,
                            UserId = 3L
                        },
                        new
                        {
                            Id = 6L,
                            Content = "iopoipio iop io io.",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9241),
                            ThemeId = 2L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 7L,
                            Content = "qq q q q q q q",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9245),
                            ThemeId = 2L,
                            UserId = 3L
                        },
                        new
                        {
                            Id = 8L,
                            Content = "N4354535 43.",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9248),
                            ThemeId = 1L,
                            UserId = 4L
                        },
                        new
                        {
                            Id = 9L,
                            Content = "po'p'l';l;l'.",
                            DateComment = new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9255),
                            ThemeId = 3L,
                            UserId = 2L
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Exam", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("smalldatetime");

                    b.Property<long>("ModuleId");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId")
                        .IsUnique();

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.ExamMark", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasMaxLength(200);

                    b.Property<long>("ExamId");

                    b.Property<long>("InternId");

                    b.Property<int>("Mark");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("InternId", "ExamId");

                    b.ToTable("ExamMarks");
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Interns123",
                            StartDate = new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Name = "interns234",
                            StartDate = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Intern", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("GroupId");

                    b.Property<long?>("MenthorId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("MenthorId")
                        .IsUnique()
                        .HasFilter("[MenthorId] IS NOT NULL");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Interns");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            GroupId = 1L,
                            MenthorId = 2L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            GroupId = 1L,
                            MenthorId = 1L,
                            UserId = 2L
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Menthor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Menthors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            UserId = 3L
                        },
                        new
                        {
                            Id = 2L,
                            UserId = 4L
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Module", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "C#",
                            StartDate = new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Name = "SQL AND EF CORE",
                            StartDate = new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Name = "WEB",
                            StartDate = new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.RequestedUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("EMail")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("TypeUser")
                        .HasMaxLength(20);

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("RequestedUsers");
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Theme", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("MenthorId")
                        .HasColumnName("MenthorId");

                    b.Property<long>("ModuleId");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("Source")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("smalldatetime");

                    b.HasKey("Id");

                    b.HasIndex("MenthorId");

                    b.HasIndex("ModuleId");

                    b.ToTable("Themes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            MenthorId = 1L,
                            ModuleId = 1L,
                            Name = "Creational Pattern",
                            Source = "S:\\Internship\\C#",
                            StartDate = new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            MenthorId = 1L,
                            ModuleId = 2L,
                            Name = "SQL SELECT",
                            Source = "S:\\Internship\\SQL",
                            StartDate = new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            MenthorId = 2L,
                            ModuleId = 2L,
                            Name = "EF Core Mapping",
                            Source = "S:\\Internship\\SQL",
                            StartDate = new DateTime(2019, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4L,
                            MenthorId = 2L,
                            ModuleId = 3L,
                            Name = "JS",
                            Source = "S:\\Internship\\WEB",
                            StartDate = new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.ThemeMark", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasMaxLength(200);

                    b.Property<long?>("InternId");

                    b.Property<int>("Mark");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long?>("ThemeId");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.HasIndex("InternId", "ThemeId");

                    b.ToTable("ThemeMarks");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Comment = "Good",
                            InternId = 1L,
                            Mark = 9,
                            ThemeId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            Comment = "No Comment",
                            InternId = 1L,
                            Mark = 1,
                            ThemeId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            Comment = "The Best",
                            InternId = 2L,
                            Mark = 10,
                            ThemeId = 2L
                        },
                        new
                        {
                            Id = 4L,
                            InternId = 1L,
                            Mark = 8,
                            ThemeId = 4L
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Identity.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ConcurrencyStamp = "-151350337",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2L,
                            ConcurrencyStamp = "756961811",
                            Name = "Menthor",
                            NormalizedName = "MENTHOR"
                        },
                        new
                        {
                            Id = 3L,
                            ConcurrencyStamp = "1727800283",
                            Name = "Intern",
                            NormalizedName = "INTERN"
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Identity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("EMail")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<long?>("RoleId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dfcaf29c-e40a-4827-90b7-7c4f82b6f3cb",
                            DateOfBirth = new DateTime(1999, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aurel@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Aurel",
                            LastName = "Starciuc",
                            LockoutEnabled = false,
                            PasswordHash = "-676656470",
                            PhoneNumber = "+37367620932",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "aurel@mail.ru"
                        },
                        new
                        {
                            Id = 2L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "19c3808b-901d-4a80-9cd2-068dbd62a802",
                            DateOfBirth = new DateTime(1989, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "cristi@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Cristi",
                            LastName = "Anghelenici",
                            LockoutEnabled = false,
                            PasswordHash = "2106376617",
                            PhoneNumber = "+37367665467",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "cristi@mail.ru"
                        },
                        new
                        {
                            Id = 3L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cffb2a68-ce21-4e7d-b757-2832602b51ca",
                            DateOfBirth = new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alexandr@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Alexandr",
                            LastName = "Racovschi",
                            LockoutEnabled = false,
                            PasswordHash = "-156999296",
                            PhoneNumber = "+37336218321",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "alexandr@mail.ru"
                        },
                        new
                        {
                            Id = 4L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bf794cc2-a4c3-44d9-89a8-7ddddec7f980",
                            DateOfBirth = new DateTime(1984, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "iong@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Ion",
                            LastName = "Gandrabura",
                            LockoutEnabled = false,
                            PasswordHash = "-695038195",
                            PhoneNumber = "+373954035",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "iong@mail.ru"
                        },
                        new
                        {
                            Id = 5L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9fe82a53-cf15-4c9d-bbef-0ed7bee7279d",
                            DateOfBirth = new DateTime(1978, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "gosa@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Gosa",
                            LastName = "Dudari",
                            LockoutEnabled = false,
                            PasswordHash = "1929270129",
                            PhoneNumber = "+37354354398",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "gosa@mail.ru"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<long>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.Property<long?>("UserId1");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId1");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Comment", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Theme", "Theme")
                        .WithMany("Comments")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Data.Domain.DomainModels.Identity.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Exam", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Module", "Module")
                        .WithOne("Exam")
                        .HasForeignKey("App.Data.Domain.DomainModels.Concrete.Exam", "ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.ExamMark", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Exam", "Exam")
                        .WithMany("ExamMarks")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Intern", "Intern")
                        .WithMany("ExamMarks")
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Intern", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Group", "Group")
                        .WithMany("Interns")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Menthor", "Menthor")
                        .WithOne("Intern")
                        .HasForeignKey("App.Data.Domain.DomainModels.Concrete.Intern", "MenthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("App.Data.Domain.DomainModels.Identity.User", "User")
                        .WithOne()
                        .HasForeignKey("App.Data.Domain.DomainModels.Concrete.Intern", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Menthor", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Identity.User", "User")
                        .WithOne()
                        .HasForeignKey("App.Data.Domain.DomainModels.Concrete.Menthor", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Theme", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Menthor", "Menthor")
                        .WithMany("Themes")
                        .HasForeignKey("MenthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Module", "Module")
                        .WithMany("Themes")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.ThemeMark", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Intern", "Intern")
                        .WithMany("ThemeMarks")
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Theme", "Theme")
                        .WithMany("ThemeMarks")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Identity.User", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Identity.Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Identity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Identity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Data.Domain.DomainModels.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Data.Domain.DomainModels.Identity.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
