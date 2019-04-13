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
    [Migration("20190413073501_v3")]
    partial class v3
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

                    b.Property<DateTime>("DateComment");

                    b.Property<long?>("ThemeId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
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

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Module", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateStart = new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2L,
                            DateStart = new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SQL AND EF CORE"
                        },
                        new
                        {
                            Id = 3L,
                            DateStart = new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "WEB"
                        });
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.RequestedUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<long>("MenthorId")
                        .HasColumnName("MenthorId");

                    b.Property<long>("ModuleId");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("Source")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("TimeOfTheme")
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
                            TimeOfTheme = new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            MenthorId = 1L,
                            ModuleId = 2L,
                            Name = "SQL SELECT",
                            Source = "S:\\Internship\\SQL",
                            TimeOfTheme = new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            MenthorId = 2L,
                            ModuleId = 2L,
                            Name = "EF Core Mapping",
                            Source = "S:\\Internship\\SQL",
                            TimeOfTheme = new DateTime(2019, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4L,
                            MenthorId = 2L,
                            ModuleId = 3L,
                            Name = "JS",
                            Source = "S:\\Internship\\WEB",
                            TimeOfTheme = new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
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

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.UserIntern", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GroupId");

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

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.UserMenthor", b =>
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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "257d19df-b232-4351-a333-9f51daf54586",
                            DateOfBirth = new DateTime(1999, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aurel@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Aurel",
                            LastName = "Starciuc",
                            LockoutEnabled = false,
                            PasswordHash = "1649895019",
                            PhoneNumber = "+37367620932",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "aurel12345"
                        },
                        new
                        {
                            Id = 2L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "575af4ca-5c93-473d-81b7-22e810467de0",
                            DateOfBirth = new DateTime(1989, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "cristi@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Cristi",
                            LastName = "Anghelenici",
                            LockoutEnabled = false,
                            PasswordHash = "654211248",
                            PhoneNumber = "+37367665467",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "cristi4324"
                        },
                        new
                        {
                            Id = 3L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "30e928b5-cc2a-4fc4-8da4-b08989df0f21",
                            DateOfBirth = new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alexandr@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Alexandr",
                            LastName = "Racovschi",
                            LockoutEnabled = false,
                            PasswordHash = "417983893",
                            PhoneNumber = "+37336218321",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "alexandr1633"
                        },
                        new
                        {
                            Id = 4L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8849337f-b66a-4449-add2-1e091d3ab27e",
                            DateOfBirth = new DateTime(1984, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "iong@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Ion",
                            LastName = "Gandrabura",
                            LockoutEnabled = false,
                            PasswordHash = "-1063559547",
                            PhoneNumber = "+373954035",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "ion79345"
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

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

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
                        .HasForeignKey("ThemeId");

                    b.HasOne("App.Data.Domain.DomainModels.Identity.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");
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

                    b.HasOne("App.Data.Domain.DomainModels.Concrete.UserIntern", "Intern")
                        .WithMany("ExamMarks")
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.Theme", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.UserMenthor", "Menthor")
                        .WithMany("Themes")
                        .HasForeignKey("MenthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Module", "Modulep")
                        .WithMany("Themes")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.ThemeMark", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.UserIntern", "Intern")
                        .WithMany("ThemeMarks")
                        .HasForeignKey("InternId");

                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Theme", "theme")
                        .WithMany("ThemeMarks")
                        .HasForeignKey("ThemeId");
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.UserIntern", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Concrete.Group", "Group")
                        .WithMany("Interns")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Data.Domain.DomainModels.Concrete.UserMenthor", "Menthor")
                        .WithOne("Intern")
                        .HasForeignKey("App.Data.Domain.DomainModels.Concrete.UserIntern", "MenthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("App.Data.Domain.DomainModels.Identity.User", "User")
                        .WithOne("Intern")
                        .HasForeignKey("App.Data.Domain.DomainModels.Concrete.UserIntern", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("App.Data.Domain.DomainModels.Concrete.UserMenthor", b =>
                {
                    b.HasOne("App.Data.Domain.DomainModels.Identity.User", "User")
                        .WithOne("Menthor")
                        .HasForeignKey("App.Data.Domain.DomainModels.Concrete.UserMenthor", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
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
