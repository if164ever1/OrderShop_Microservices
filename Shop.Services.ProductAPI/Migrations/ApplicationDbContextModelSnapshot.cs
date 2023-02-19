﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Services.ProductAPI.DbContaxts;

#nullable disable

namespace Shop.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Monitor",
                            Description = "68.6 cm (27\") 16:9, IPS-Panel (matt)",
                            ImageUrl = "https://img.computerunivers.net/images/400x400/908610758A1A6A22A492410BAD9A4C32.jpg",
                            Name = "LG UltraGear 27GN800-B 68.6 cm (27\") WQHD Monitor",
                            Price = 289.89999999999998
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Monitor",
                            Description = "1920 x 1080 Full HD, Reaktionszeit 1 ms, HDR10",
                            ImageUrl = "https://img.computerunivers.net/images/400x400/90912818F785671B23BD4C2A93CB400E.jpg",
                            Name = "LG UltraGear 24GN60R-B 61.0 cm (24\") Full HD Monitor",
                            Price = 173.90000000000001
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Monitor",
                            Description = "68.6 cm (27\") 16:9 Curved, VA-Panel",
                            ImageUrl = "https://img.computerunivers.net/images/400x400/9078908779FE8FA2CB54449EB7996CD7.jpg",
                            Name = "AOC CQ27G2U/BK 68.6 cm (27\") WQHD Monitor",
                            Price = 259.89999999999998
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryName = "Monitor",
                            Description = "up to 165 Hz, Adaptive Sync / FreeSync, G-SYNC®, G-SYNC® kompatibel",
                            ImageUrl = "https://img.computerunivers.net/images/400x400/90777448CE8646DF987A45B098375EA1.jpg",
                            Name = "ASUS TUF VG27AQ 68.6 cm (27\") WQHD Monitor",
                            Price = 319.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
