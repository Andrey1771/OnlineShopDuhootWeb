﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShopDuhootWeb.Data;

namespace OnlineShopDuhootWeb.Migrations
{
    [DbContext(typeof(OnlineShopDuhootWebContext))]
    partial class OnlineShopDuhootWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "58704fbc-843e-47bc-971a-1e28bccf6501",
                            ConcurrencyStamp = "30ee76a1-a93a-44e8-b30e-ebdc32aa3df4",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "3cc5e7b1-5d92-4e56-8149-1d895abf236c",
                            RoleId = "58704fbc-843e-47bc-971a-1e28bccf6501"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.OnlineShopDuhootWebUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("Postcode")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "3cc5e7b1-5d92-4e56-8149-1d895abf236c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "06a4182e-7d8e-42b8-81a9-014cdebac373",
                            DateBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "my@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MY@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEIuxh7Ikuc8tqrg9aElX+cKY9drnDkf7EmNQUcsW8z8cEyls6z9xgUKfW99DuJ7VsQ==",
                            PhoneNumberConfirmed = false,
                            Postcode = 0,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProducerId");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            ProducerId = 1,
                            ContactInformation = "Test_ContactInformation_1",
                            Description = "Test_Description_1",
                            Location = "Test_Location_1",
                            Name = "Test_Name_1_Producer"
                        },
                        new
                        {
                            ProducerId = 2,
                            ContactInformation = "Test_ContactInformation_2",
                            Description = "Test_Description_2",
                            Location = "Test_Location_2",
                            Name = "Test_Name_2_Producer"
                        },
                        new
                        {
                            ProducerId = 3,
                            ContactInformation = "Test_ContactInformation_3",
                            Description = "Test_Description_3",
                            Location = "Test_Location_3",
                            Name = "Test_Name_3_Producer"
                        },
                        new
                        {
                            ProducerId = 4,
                            ContactInformation = "Test_ContactInformation_4",
                            Description = "Test_Description_4",
                            Location = "Test_Location_4",
                            Name = "Test_Name_4_Producer"
                        },
                        new
                        {
                            ProducerId = 5,
                            ContactInformation = "Test_ContactInformation_5",
                            Description = "Test_Description_5",
                            Location = "Test_Location_5",
                            Name = "Test_Name_5_Producer"
                        },
                        new
                        {
                            ProducerId = 6,
                            ContactInformation = "Test_ContactInformation_6",
                            Description = "Test_Description_6",
                            Location = "Test_Location_6",
                            Name = "Test_Name_6_Producer"
                        });
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Test_Product_Description",
                            Name = "Test_Product",
                            ProducerId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Test_Product_Description_2",
                            Name = "Test_Product_2",
                            ProducerId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Test_Product_Description_3",
                            Name = "Test_Product_3",
                            ProducerId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Test_Product_Description_4",
                            Name = "Test_Product_4",
                            ProducerId = 3
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "Test_Product_Description_5",
                            Name = "Test_Product_5",
                            ProducerId = 4
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "Test_Product_Description_6",
                            Name = "Test_Product_6",
                            ProducerId = 5
                        });
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.ProductSiteCard", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("BackgroundImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountComments")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeAdded")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("RightTopText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeCard")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("ProductSiteCards");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BackgroundImage = "images/footerBack.jpg",
                            CountComments = 365,
                            DateTimeAdded = new DateTime(2021, 4, 5, 23, 10, 12, 896, DateTimeKind.Local).AddTicks(5291),
                            Rating = 4,
                            RightTopText = "$2,990",
                            Text = "2 bedroom house for rent in Dubai",
                            Title = "VISION AGENCY",
                            TypeCard = 0
                        },
                        new
                        {
                            ProductId = 2,
                            BackgroundImage = "images/footerBack.jpg",
                            CountComments = 1109,
                            DateTimeAdded = new DateTime(2021, 4, 5, 23, 10, 12, 897, DateTimeKind.Local).AddTicks(6311),
                            Rating = 5,
                            RightTopText = "$3,100,000",
                            Text = "3 bedroom apartment in Moscow",
                            Title = "Moscow Hostel",
                            TypeCard = 1
                        },
                        new
                        {
                            ProductId = 3,
                            BackgroundImage = "images/footerBack.jpg",
                            CountComments = 627,
                            DateTimeAdded = new DateTime(2021, 4, 5, 23, 10, 12, 897, DateTimeKind.Local).AddTicks(6329),
                            Rating = 4,
                            RightTopText = "$5,990",
                            Text = "High quality education and student life",
                            Title = "MIET",
                            TypeCard = 2
                        },
                        new
                        {
                            ProductId = 4,
                            BackgroundImage = "images/footerBack.jpg",
                            CountComments = 550,
                            DateTimeAdded = new DateTime(2021, 4, 5, 23, 10, 12, 897, DateTimeKind.Local).AddTicks(6332),
                            Rating = 5,
                            RightTopText = "$99",
                            Text = "Hookah bar and modern music club",
                            Title = "Euphoria",
                            TypeCard = 3
                        },
                        new
                        {
                            ProductId = 5,
                            BackgroundImage = "images/footerBack.jpg",
                            CountComments = 365,
                            DateTimeAdded = new DateTime(2021, 4, 5, 23, 10, 12, 897, DateTimeKind.Local).AddTicks(6334),
                            Rating = 4,
                            RightTopText = "$190",
                            Text = "Bus transportation between major cities",
                            Title = "TravelSuit",
                            TypeCard = 4
                        });
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.UserPaySettings", b =>
                {
                    b.Property<int>("UserPaySettingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("NumberCard")
                        .HasColumnType("bigint");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ValidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserPaySettingsId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPaySettings");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersOrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("OrdersOrderId", "ProductsProductId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("OrderProduct");
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
                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.OnlineShopDuhootWebUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.OnlineShopDuhootWebUser", null)
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

                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.OnlineShopDuhootWebUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.OnlineShopDuhootWebUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.Order", b =>
                {
                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.OnlineShopDuhootWebUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.Product", b =>
                {
                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.Producer", "Producer")
                        .WithMany("Products")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.ProductSiteCard", b =>
                {
                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.Product", "Product")
                        .WithOne("SiteCard")
                        .HasForeignKey("OnlineShopDuhootWeb.Areas.Identity.Data.ProductSiteCard", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.UserPaySettings", b =>
                {
                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.OnlineShopDuhootWebUser", "User")
                        .WithMany("PaySettings")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineShopDuhootWeb.Areas.Identity.Data.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.OnlineShopDuhootWebUser", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("PaySettings");
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.Producer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OnlineShopDuhootWeb.Areas.Identity.Data.Product", b =>
                {
                    b.Navigation("SiteCard");
                });
#pragma warning restore 612, 618
        }
    }
}
