﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Orion.DataAccess.DataBase;

namespace Orion.DataAccess.Migrations
{
    [DbContext(typeof(GlobalDbContext))]
    [Migration("20230118030849_mig-04")]
    partial class mig04
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Orion.Domain.Entity.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact");

                    b.Property<string>("Contractor");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Engineer");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<int>("Number");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Orion.Domain.Entity.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("Orion.Domain.Entity.Spec", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("TitleId");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.ToTable("Specs");
                });

            modelBuilder.Entity("Orion.Domain.Entity.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogA1Id");

                    b.Property<int?>("CatalogA2Id");

                    b.Property<int?>("CatalogA3Id");

                    b.Property<int?>("CatalogA4Id");

                    b.Property<int?>("CatalogB1Id");

                    b.Property<int?>("CatalogB2Id");

                    b.Property<int?>("CatalogB3Id");

                    b.Property<int?>("CatalogB4Id");

                    b.Property<int?>("CatalogB5Id");

                    b.Property<int?>("ItemA1Id");

                    b.Property<int?>("ItemA2Id");

                    b.Property<int?>("ItemA3Id");

                    b.Property<int?>("ItemA4Id");

                    b.Property<int?>("ItemB1Id");

                    b.Property<int?>("ItemB2Id");

                    b.Property<int?>("ItemB3Id");

                    b.Property<int?>("ItemB4Id");

                    b.Property<int?>("ItemB5Id");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CatalogA1Id");

                    b.HasIndex("CatalogA2Id");

                    b.HasIndex("CatalogA3Id");

                    b.HasIndex("CatalogA4Id");

                    b.HasIndex("CatalogB1Id");

                    b.HasIndex("CatalogB2Id");

                    b.HasIndex("CatalogB3Id");

                    b.HasIndex("CatalogB4Id");

                    b.HasIndex("CatalogB5Id");

                    b.HasIndex("ItemA1Id");

                    b.HasIndex("ItemA2Id");

                    b.HasIndex("ItemA3Id");

                    b.HasIndex("ItemA4Id");

                    b.HasIndex("ItemB1Id");

                    b.HasIndex("ItemB2Id");

                    b.HasIndex("ItemB3Id");

                    b.HasIndex("ItemB4Id");

                    b.HasIndex("ItemB5Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("Orion.Domain.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("LoginName");

                    b.Property<string>("Name");

                    b.Property<string>("PassKey");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogABB.CatalogB1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.HasKey("Id");

                    b.ToTable("CatalogB1s");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogABB.CatalogB2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.HasKey("Id");

                    b.ToTable("CatalogB2s");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogABB.CatalogB3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.HasKey("Id");

                    b.ToTable("CatalogB3s");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogABB.CatalogB4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.HasKey("Id");

                    b.ToTable("CatalogB4s");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogABB.CatalogB5", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.HasKey("Id");

                    b.ToTable("CatalogB5s");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogQuantech.CatalogA1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<string>("Description");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.Property<string>("UnitSize");

                    b.Property<string>("Voltage");

                    b.HasKey("Id");

                    b.ToTable("CatalogA1s");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogQuantech.CatalogA2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<string>("Description");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.Property<string>("UnitSize");

                    b.Property<string>("Voltage");

                    b.HasKey("Id");

                    b.ToTable("CatalogA2s");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogQuantech.CatalogA3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<string>("Description");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.Property<string>("UnitSize");

                    b.Property<string>("Voltage");

                    b.HasKey("Id");

                    b.ToTable("CatalogA3s");
                });

            modelBuilder.Entity("Orion.Domain.EntityCatalogQuantech.CatalogA4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostMultiplier");

                    b.Property<string>("Description");

                    b.Property<double>("ListPrice");

                    b.Property<string>("Model");

                    b.Property<double>("SellMargin");

                    b.Property<string>("UnitSize");

                    b.Property<string>("Voltage");

                    b.HasKey("Id");

                    b.ToTable("CatalogA4s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItem.ItemA1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogA1Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogA1Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemA1s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItem.ItemA2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogA2Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogA2Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemA2s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItem.ItemA3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogA3Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogA3Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemA3s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItem.ItemA4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogA4Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogA4Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemA4s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogB1Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogB1Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemB1s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogB2Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogB2Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemB2s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogB3Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogB3Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemB3s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogB4Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogB4Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemB4s");
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB5", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogB5Id");

                    b.Property<double>("CostMultiplier");

                    b.Property<int>("DesignIndex");

                    b.Property<bool>("IsExcluded");

                    b.Property<double>("ListPrice");

                    b.Property<bool>("OverridePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("QuoteId");

                    b.Property<double>("SellMargin");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CatalogB5Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("ItemB5s");
                });

            modelBuilder.Entity("Orion.Domain.Entity.Project", b =>
                {
                    b.HasOne("Orion.Domain.Entity.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.Entity.Quote", b =>
                {
                    b.HasOne("Orion.Domain.Entity.Project", "Project")
                        .WithMany("Quotes")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.Entity.Spec", b =>
                {
                    b.HasOne("Orion.Domain.Entity.Title", "Title")
                        .WithMany("Specs")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.Entity.Title", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogQuantech.CatalogA1", "CatalogA1")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogA1Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityCatalogQuantech.CatalogA2", "CatalogA2")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogA2Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityCatalogQuantech.CatalogA3", "CatalogA3")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogA3Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityCatalogQuantech.CatalogA4", "CatalogA4")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogA4Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB1", "CatalogB1")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogB1Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB2", "CatalogB2")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogB2Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB3", "CatalogB3")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogB3Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB4", "CatalogB4")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogB4Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB5", "CatalogB5")
                        .WithMany("Titles")
                        .HasForeignKey("CatalogB5Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItem.ItemA1", "ItemA1")
                        .WithMany("Titles")
                        .HasForeignKey("ItemA1Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItem.ItemA2", "ItemA2")
                        .WithMany("Titles")
                        .HasForeignKey("ItemA2Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItem.ItemA3", "ItemA3")
                        .WithMany("Titles")
                        .HasForeignKey("ItemA3Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItem.ItemA4", "ItemA4")
                        .WithMany("Titles")
                        .HasForeignKey("ItemA4Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItemABB.ItemB1", "ItemB1")
                        .WithMany("Titles")
                        .HasForeignKey("ItemB1Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItemABB.ItemB2", "ItemB2")
                        .WithMany("Titles")
                        .HasForeignKey("ItemB2Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItemABB.ItemB3", "ItemB3")
                        .WithMany("Titles")
                        .HasForeignKey("ItemB3Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItemABB.ItemB4", "ItemB4")
                        .WithMany("Titles")
                        .HasForeignKey("ItemB4Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Orion.Domain.EntityItemABB.ItemB5", "ItemB5")
                        .WithMany("Titles")
                        .HasForeignKey("ItemB5Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Orion.Domain.EntityItem.ItemA1", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogQuantech.CatalogA1", "CatalogA1")
                        .WithMany()
                        .HasForeignKey("CatalogA1Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemA1s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.EntityItem.ItemA2", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogQuantech.CatalogA2", "CatalogA2")
                        .WithMany()
                        .HasForeignKey("CatalogA2Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemA2s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.EntityItem.ItemA3", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogQuantech.CatalogA3", "CatalogA3")
                        .WithMany()
                        .HasForeignKey("CatalogA3Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemA3s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.EntityItem.ItemA4", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogQuantech.CatalogA4", "CatalogA4")
                        .WithMany()
                        .HasForeignKey("CatalogA4Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemA4s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB1", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB1", "CatalogB1")
                        .WithMany()
                        .HasForeignKey("CatalogB1Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemB1s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB2", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB2", "CatalogB2")
                        .WithMany()
                        .HasForeignKey("CatalogB2Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemB2s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB3", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB3", "CatalogB3")
                        .WithMany()
                        .HasForeignKey("CatalogB3Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemB3s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB4", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB4", "CatalogB4")
                        .WithMany()
                        .HasForeignKey("CatalogB4Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemB4s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orion.Domain.EntityItemABB.ItemB5", b =>
                {
                    b.HasOne("Orion.Domain.EntityCatalogABB.CatalogB5", "CatalogB5")
                        .WithMany()
                        .HasForeignKey("CatalogB5Id");

                    b.HasOne("Orion.Domain.Entity.Quote", "Quote")
                        .WithMany("ItemB5s")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
