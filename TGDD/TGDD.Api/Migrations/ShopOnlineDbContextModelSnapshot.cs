﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TGDD.Api.Data;

#nullable disable

namespace TGDD.Api.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    partial class ShopOnlineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TGDD.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TGDD.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("TGDD.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductImages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Apple",
                            CategoryId = 1,
                            Color = "Blue Titanium",
                            Description = "Latest iPhone model",
                            ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_300x300/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-thumbtz-650x650.png",
                            Name = "IPhone 15 Pro Max",
                            Price = 1409.61m,
                            ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305658/s16/iphone-15-pro-max-blue-titan-7-650x650.jpg",
                            ProductLine = "iPhone",
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Apple",
                            CategoryId = 1,
                            Color = "White Titanium",
                            Description = "Latest iPhone model",
                            ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-thumbtz-650x650.png",
                            Name = "IPhone 15 Pro Max",
                            Price = 1362.23m,
                            ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-4-200x200.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/42/305660/s16/iphone-15-pro-max-white-titan-4-200x200.jpg",
                            ProductLine = "iPhone",
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Apple",
                            CategoryId = 1,
                            Color = "Natural Titanium",
                            Description = "Latest iPhone model",
                            ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-thumbtz-650x650.png",
                            Name = "IPhone 15 Pro",
                            Price = 1731.19m,
                            ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-0-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303833/s16/iphone-15-pro-tu-nhien-3-650x650.jpg",
                            ProductLine = "iPhone",
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Apple",
                            CategoryId = 1,
                            Color = "Yellow",
                            Description = "Latest iPhone model",
                            ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-yellow-thumbtz-650x650.png",
                            Name = "IPhone 15 Plus",
                            Price = 1195.22m,
                            ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-yellow-thumbtz-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-1-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/42/303823/s16/iphone-15-plus-vang-8-650x650.jpg",
                            ProductLine = "iPhone",
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Apple",
                            CategoryId = 2,
                            Color = "Midnight",
                            Description = "The latest MacBook model",
                            ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png",
                            Name = "MacBook Pro 16 inch M3 Pro 2023",
                            Price = 3091.73m,
                            ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318236/s16/apple-macbook-pro-16-inch-m3-max-2023-16-core-black-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-9-650x650.jpg",
                            ProductLine = "MacBook",
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Apple",
                            CategoryId = 2,
                            Color = "Silver",
                            Description = "The latest MacBook model",
                            ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-silver-650x650.png",
                            Name = "MacBook Pro 16 inch M3 Pro 2023",
                            Price = 3091.73m,
                            ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-silver-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-max-2023-14-core-silver-9-650x650.jpg",
                            ProductLine = "MacBook",
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Apple",
                            CategoryId = 2,
                            Color = "Golden",
                            Description = "The latest MacBook model",
                            ImageURL = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_300x300/https://cdn.tgdd.vn/Products/Images/44/231244/s16/mac-air-13-m1-vang-650x650.png",
                            Name = "MacBook Air 13 inch M1 2020",
                            Price = 803.28m,
                            ProductImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/mac-air-13-m1-vang-200x200.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-gold-01-200x200.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-gold-02-200x200.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-gold-03-200x200.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_75,s_100x100/https://cdn.tgdd.vn/Products/Images/44/231244/s16/macbook-air-m1-gold-04-200x200.jpg",
                            ProductLine = "MacBook",
                            Qty = 200
                        });
                });

            modelBuilder.Entity("TGDD.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BannerImages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BannerImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2024/01/banner/iPhone13-2400-600-1920x480.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/iPhone11-2400-600-1920x480.png",
                            IconCSS = "bi bi-phone",
                            Name = "Phone"
                        },
                        new
                        {
                            Id = 2,
                            BannerImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Mac-Air-M2-2400-600-1920x480.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Mac-Air-M1-2400-600-1920x480.png",
                            IconCSS = "bi bi-laptop",
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            BannerImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/ipad9-2400-600-1920x480.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2024/01/banner/iPad-Air5-2400-600-1920x480.png",
                            IconCSS = "bi bi-tablet",
                            Name = "Tablet"
                        },
                        new
                        {
                            Id = 4,
                            BannerImages = "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Phu-kien-2400-600-1920x480-2.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2024/01/banner/OLIP-15-2400-600-1920x480.png",
                            IconCSS = "fas fa-shoe-prints",
                            Name = "Accessory"
                        });
                });

            modelBuilder.Entity("TGDD.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Hao"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Dung"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TGDD.Api.Entities.Product", b =>
                {
                    b.HasOne("TGDD.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
