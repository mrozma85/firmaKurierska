﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt.Data.Data;

#nullable disable

namespace Projekt.Data.Migrations
{
    [DbContext(typeof(ProjektContext))]
    [Migration("20220414214800_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Projekt.Data.Data.CMS.Nawigacja", b =>
                {
                    b.Property<int>("IdNawigacji")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNawigacji"), 1L, 1);

                    b.Property<string>("LinkNawigacji")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("TrescNawigacji")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("TytulNawigacji")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNawigacji");

                    b.ToTable("Nawigacja");
                });
#pragma warning restore 612, 618
        }
    }
}
