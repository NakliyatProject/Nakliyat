﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(NakliyatDbContext))]
    [Migration("20230917160846_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("da6b744d-45af-407b-b4a5-15b85f074bf5"),
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7183),
                            CustomerName = "Customer1",
                            CustomerSurname = "Surname",
                            Email = "user1@gmail.com",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a1903ec3-9b8c-4255-a250-7003756c02e0"),
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7186),
                            CustomerName = "Customer2",
                            CustomerSurname = "Surname",
                            Email = "user2@gmail.com",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4cb71b96-06d0-4e89-ad19-8e57e841294c"),
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7188),
                            CustomerName = "Customer3",
                            CustomerSurname = "Surname",
                            Email = "user3@gmail.com",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("bc735ee9-9c69-429d-b8be-475ea0cbb4c0"),
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7190),
                            CustomerName = "Customer4",
                            CustomerSurname = "Surname",
                            Email = "user4@gmail.com",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("aa8473f3-5d5a-4b15-ae8b-1d90cf80f31a"),
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7192),
                            CustomerName = "Customer5",
                            CustomerSurname = "Surname",
                            Email = "user5@gmail.com",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Ekip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AracImgUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AracName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AracPlakasi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EkipLead")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EkipName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EkipRank")
                        .HasColumnType("integer");

                    b.Property<string>("EkipTelNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EkipYorumSayisi")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("durum")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Ekipler");
                });

            modelBuilder.Entity("Domain.Entities.TasimaTalebi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Baslangic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Bitis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EsyaImgUrl")
                        .HasColumnType("text");

                    b.Property<int>("Mesafe")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("TasimaTalebleri");

                    b.HasData(
                        new
                        {
                            Id = new Guid("440b2f77-61ec-447a-934e-ed34c4ae479c"),
                            Aciklama = "tasimatalebi1",
                            Baslangic = "istanbul",
                            Bitis = "kars",
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7729),
                            EsyaImgUrl = "laptop.jpeg",
                            Mesafe = 150,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e26779cc-3224-4af5-9549-2137005bba23"),
                            Aciklama = "tasimatalebi2",
                            Baslangic = "istanbul",
                            Bitis = "ardahan",
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7731),
                            EsyaImgUrl = "laptop.jpeg",
                            Mesafe = 150,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("5688bb8f-2260-4289-8cf2-158d1457c600"),
                            Aciklama = "tasimatalebi3",
                            Baslangic = "istanbul",
                            Bitis = "igdir",
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7733),
                            EsyaImgUrl = "laptop.jpeg",
                            Mesafe = 150,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("254ea49f-421d-422f-a792-5d11c077b070"),
                            Aciklama = "tasimatalebi4",
                            Baslangic = "istanbul",
                            Bitis = "agri",
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7735),
                            EsyaImgUrl = "laptop.jpeg",
                            Mesafe = 150,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("132074d1-ad2b-43c3-a224-85acbaad8aaa"),
                            Aciklama = "tasimatalebi5",
                            Baslangic = "istanbul",
                            Bitis = "van",
                            CreatedDate = new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7736),
                            EsyaImgUrl = "laptop.jpeg",
                            Mesafe = 150,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "4f9f9c0f-f0e9-48c0-9b5c-35859ab1d678",
                            ConcurrencyStamp = "ed4336e7-fa1c-4bac-867f-067f99173ecc",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "30b8ca64-17e2-49ed-8a4f-70a2f1412b70",
                            ConcurrencyStamp = "e5cacc1c-ebb7-478c-8bd9-7fc7ca8e6721",
                            Name = "Company",
                            NormalizedName = "COMPANY"
                        },
                        new
                        {
                            Id = "f6cff14c-1cde-458b-a2b5-5880570d1fe8",
                            ConcurrencyStamp = "e6248ba6-3abf-4697-b7fd-6eec79609c1c",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "cb983aac-8f9f-4436-8bcb-d9b3cd3a74c8",
                            ConcurrencyStamp = "0b5b6db0-9de7-40e7-a1cb-fbf94f1a2786",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
#pragma warning restore 612, 618
        }
    }
}
