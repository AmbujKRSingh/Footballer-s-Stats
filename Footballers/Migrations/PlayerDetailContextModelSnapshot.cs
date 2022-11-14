﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayerAPI.Models;

#nullable disable

namespace Footballers.Migrations
{
    [DbContext(typeof(PlayerDetailContext))]
    partial class PlayerDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlayerAPI.Models.PlayerDetail", b =>
                {
                    b.Property<int>("PlayerDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerDetailId"));

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<int>("Goals")
                        .HasColumnType("int");

                    b.Property<int>("JerseyNo")
                        .HasColumnType("int");

                    b.Property<string>("PlayerCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("PlayerDetailId");

                    b.ToTable("PlayerDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
