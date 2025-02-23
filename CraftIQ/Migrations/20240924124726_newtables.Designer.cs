﻿// <auto-generated />
using System;
using CraftIQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CraftIQ.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240924124726_newtables")]
    partial class newtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProducts", b =>
                {
                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("productsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoriesId", "productsId");

                    b.HasIndex("productsId");

                    b.ToTable("CategoryProducts");
                });

            modelBuilder.Entity("CraftIQ.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CraftIQ.Models.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("CraftIQ.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpectedDeliverydate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDat")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderType")
                        .HasColumnType("int");

                    b.Property<DateTime>("Receiveddate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CraftIQ.Models.OrderDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CraftIQ.Models.Products", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Hieght")
                        .HasColumnType("real");

                    b.Property<Guid?>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductionCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProfitPerUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TaxCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("TransactionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("Width")
                        .HasColumnType("real");

                    b.Property<float>("Wieght")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.HasIndex("TransactionsId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CraftIQ.Models.Transactions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CategoryProducts", b =>
                {
                    b.HasOne("CraftIQ.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CraftIQ.Models.Products", null)
                        .WithMany()
                        .HasForeignKey("productsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CraftIQ.Models.OrderDetails", b =>
                {
                    b.HasOne("CraftIQ.Models.Order", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CraftIQ.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("CraftIQ.Models.Products", b =>
                {
                    b.HasOne("CraftIQ.Models.Inventory", null)
                        .WithMany("Produces")
                        .HasForeignKey("InventoryId");

                    b.HasOne("CraftIQ.Models.Transactions", null)
                        .WithMany("Products")
                        .HasForeignKey("TransactionsId");
                });

            modelBuilder.Entity("CraftIQ.Models.Inventory", b =>
                {
                    b.Navigation("Produces");
                });

            modelBuilder.Entity("CraftIQ.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("CraftIQ.Models.Transactions", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
