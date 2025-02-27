﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Models.Configurations
{
    public partial class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.ToTable("Genre");

            entity.Property(e => e.Name).HasMaxLength(120);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Genre> entity);
    }
}
