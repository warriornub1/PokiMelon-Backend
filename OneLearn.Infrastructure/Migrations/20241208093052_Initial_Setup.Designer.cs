﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneLearn.Infrastructure.Common.DBContexts;

#nullable disable

namespace OneLearn.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241208093052_Initial_Setup")]
    partial class Initial_Setup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OneLearn.Domain.Transactions.VoiceTranslation.Language", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("language")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("language_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("last_modified_by")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("last_modified_on")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("language", "language_Code")
                        .IsUnique();

                    b.ToTable("Language");
                });
#pragma warning restore 612, 618
        }
    }
}
