﻿// <auto-generated />
using System;
using BillTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BillTracker.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211125222045_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BillTracker.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GST")
                        .HasColumnType("float");

                    b.Property<int>("GSTHSTRefNo")
                        .HasColumnType("int");

                    b.Property<double>("HST")
                        .HasColumnType("float");

                    b.Property<DateTime>("InvcDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PST")
                        .HasColumnType("float");

                    b.Property<string>("ProcessedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProdDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<int>("TerminanlID")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<double>("TotalTax")
                        .HasColumnType("float");

                    b.HasKey("InvoiceNumber");

                    b.HasIndex("ProductID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("BillTracker.Models.Product", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("ProdCategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("ProdCategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BillTracker.Models.Product+Category", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BillTracker.Models.Invoice", b =>
                {
                    b.HasOne("BillTracker.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BillTracker.Models.Product", b =>
                {
                    b.HasOne("BillTracker.Models.Product+Category", "ProdCategory")
                        .WithMany()
                        .HasForeignKey("ProdCategoryID");

                    b.Navigation("ProdCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
