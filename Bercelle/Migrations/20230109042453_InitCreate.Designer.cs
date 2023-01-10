﻿// <auto-generated />
using System;
using Bercelle.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bercelle.Migrations
{
    [DbContext(typeof(BercelleContext))]
    [Migration("20230109042453_InitCreate")]
    partial class InitCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Bercelle.Models.Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_admin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("Bercelle.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Customerid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_customer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("nameprd")
                        .HasColumnType("INTEGER");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("Customerid");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("Bercelle.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("namectg")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Bercelle.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("address")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("id_oderdetail")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Bercelle.Models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Customerid")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Customerid1")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dategh")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("datemh")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("datenh")
                        .HasColumnType("TEXT");

                    b.Property<int>("id_customer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nameprd")
                        .HasColumnType("TEXT");

                    b.Property<double>("price")
                        .HasColumnType("REAL");

                    b.Property<string>("status")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Customerid");

                    b.HasIndex("Customerid1");

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("Bercelle.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cartid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<byte>("image")
                        .HasColumnType("INTEGER");

                    b.Property<string>("namectg")
                        .HasColumnType("TEXT");

                    b.Property<string>("nameprd")
                        .HasColumnType("TEXT");

                    b.Property<float>("price")
                        .HasColumnType("REAL");

                    b.Property<int>("quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("Cartid");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("categoriesid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productsid")
                        .HasColumnType("INTEGER");

                    b.HasKey("categoriesid", "productsid");

                    b.HasIndex("productsid");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("Bercelle.Models.Cart", b =>
                {
                    b.HasOne("Bercelle.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customerid");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Bercelle.Models.OrderDetail", b =>
                {
                    b.HasOne("Bercelle.Models.Customer", null)
                        .WithMany("orders")
                        .HasForeignKey("Customerid");

                    b.HasOne("Bercelle.Models.Cart", "Customer")
                        .WithMany()
                        .HasForeignKey("Customerid1");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Bercelle.Models.Product", b =>
                {
                    b.HasOne("Bercelle.Models.Cart", null)
                        .WithMany("products")
                        .HasForeignKey("Cartid");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("Bercelle.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("categoriesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bercelle.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("productsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bercelle.Models.Cart", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Bercelle.Models.Customer", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
