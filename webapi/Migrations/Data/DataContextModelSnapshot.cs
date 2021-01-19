﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webapi.Infrastructure.Data;

namespace webapi.Migrations.Data
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("webapi.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int?>("LogoAttachmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.HasKey("AccountId");

                    b.HasIndex("LogoAttachmentId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("webapi.Entities.AccountCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.HasKey("CategoryId", "AccountId");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountCategories");
                });

            modelBuilder.Entity("webapi.Entities.AccountCity", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.HasKey("CityId", "AccountId");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountCities");
                });

            modelBuilder.Entity("webapi.Entities.Attachment", b =>
                {
                    b.Property<int>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("integer");

                    b.Property<string>("AttachmentType")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AttachmentId");

                    b.HasIndex("AccountId");

                    b.ToTable("Attachment");
                });

            modelBuilder.Entity("webapi.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("ImageAttachmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.HasIndex("ImageAttachmentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("webapi.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("webapi.Entities.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<string>("CustomCondition")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsNotValidWithOtherPromotion")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSomeConditionApply")
                        .HasColumnType("boolean");

                    b.Property<string>("OfferType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OfferValue")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CouponId");

                    b.HasIndex("AccountId");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("webapi.Entities.CouponCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CouponId")
                        .HasColumnType("integer");

                    b.HasKey("CategoryId", "CouponId");

                    b.HasIndex("CouponId");

                    b.ToTable("CouponCategories");
                });

            modelBuilder.Entity("webapi.Entities.CouponCity", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("CouponId")
                        .HasColumnType("integer");

                    b.HasKey("CityId", "CouponId");

                    b.HasIndex("CouponId");

                    b.ToTable("CouponCities");
                });

            modelBuilder.Entity("webapi.Entities.SocialLink", b =>
                {
                    b.Property<int>("SocialLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("integer");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SocialName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SocialLinkId");

                    b.HasIndex("AccountId");

                    b.ToTable("SocialLink");
                });

            modelBuilder.Entity("webapi.Entities.Account", b =>
                {
                    b.HasOne("webapi.Entities.Attachment", "Logo")
                        .WithMany()
                        .HasForeignKey("LogoAttachmentId");
                });

            modelBuilder.Entity("webapi.Entities.AccountCategory", b =>
                {
                    b.HasOne("webapi.Entities.Account", "Account")
                        .WithMany("AccountCategories")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.Entities.AccountCity", b =>
                {
                    b.HasOne("webapi.Entities.Account", "Account")
                        .WithMany("AccountCities")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.Entities.Attachment", b =>
                {
                    b.HasOne("webapi.Entities.Account", null)
                        .WithMany("Attachments")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("webapi.Entities.Category", b =>
                {
                    b.HasOne("webapi.Entities.Attachment", "Image")
                        .WithMany()
                        .HasForeignKey("ImageAttachmentId");
                });

            modelBuilder.Entity("webapi.Entities.Coupon", b =>
                {
                    b.HasOne("webapi.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.Entities.CouponCategory", b =>
                {
                    b.HasOne("webapi.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Entities.Coupon", "Coupon")
                        .WithMany("CouponCategories")
                        .HasForeignKey("CouponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.Entities.CouponCity", b =>
                {
                    b.HasOne("webapi.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Entities.Coupon", "Coupon")
                        .WithMany("CouponCities")
                        .HasForeignKey("CouponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.Entities.SocialLink", b =>
                {
                    b.HasOne("webapi.Entities.Account", null)
                        .WithMany("SocialLinks")
                        .HasForeignKey("AccountId");
                });
#pragma warning restore 612, 618
        }
    }
}