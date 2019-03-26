﻿using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configs.Configurations
{
    class ThemeConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> builder)
        {
            builder.ToTable("Themes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(20);
            builder.Property(x => x.Source).HasMaxLength(100);
            builder.Property(x => x.TimeOfTheme).HasColumnType("smalldatetime");
            builder.Property(x => x.MenthorId).HasColumnName("MenthorId");
            builder.HasOne(x => x.Modulep).WithMany(x => x.Themes).HasForeignKey(x => x.ModuleId);
            builder.HasOne(x => x.Menthor).WithMany(x => x.Themes).HasForeignKey(x => x.MenthorId);

            builder.HasData(
                new Theme
                {
                    Id = 1,
                    Name = "Creational Pattern",
                    TimeOfTheme = Convert.ToDateTime("2019/02/06"),
                    Source = "S:\\Internship\\C#",
                    MenthorId = 1,
                    ModuleId = 1
                },
                new Theme
                {
                    Id = 2,
                    Name = "SQL SELECT",
                    TimeOfTheme = Convert.ToDateTime("2019/03/01"),
                    Source = "S:\\Internship\\SQL",
                    MenthorId = 1,
                    ModuleId = 2
                }, new Theme
                {
                    Id = 3,
                    Name = "EF Core Mapping",
                    TimeOfTheme = Convert.ToDateTime("2019/03/16"),
                    Source = "S:\\Internship\\SQL",
                    MenthorId = 2,
                    ModuleId = 2
                },
                new Theme
                {
                    Id = 4,
                    Name = "JS",
                    TimeOfTheme = Convert.ToDateTime("2019/04/02"),
                    Source = "S:\\Internship\\WEB",
                    MenthorId = 2,
                    ModuleId = 3
                }
                );
        }
    }
}
