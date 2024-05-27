﻿// <auto-generated />
using FilmesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmesAPI.Migrations;

[DbContext(typeof(FilmeContext))]
partial class FilmeContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.5")
            .HasAnnotation("Relational:MaxIdentifierLength", 64);

        MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

        modelBuilder.Entity("FilmesAPI.Models.Filme", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Duracao")
                    .HasColumnType("int");

                b.Property<string>("Genero")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                b.Property<string>("Titulo")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.HasKey("Id");

                b.ToTable("Filmes");
            });
#pragma warning restore 612, 618
    }
}
