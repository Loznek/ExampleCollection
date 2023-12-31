﻿// <auto-generated />
using System;
using ExampleCollection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExampleCollection.Migrations
{
    [DbContext(typeof(AdatvezDbContext))]
    [Migration("20231201153310_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExampleCollection.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("ParentCategoryID");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.CategoryWithParent", b =>
                {
                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ParentCategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToView("CategoryWithParent");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BankAccount")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Login")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MainCustomerSiteId")
                        .HasColumnType("int")
                        .HasColumnName("MainCustomerSiteID");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MainCustomerSiteId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.CustomerSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<string>("Fax")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tel")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerSite", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<bool?>("Cancelled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CustomerCity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerStreet")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerZipCode")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .IsFixedLength();

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("InvoiceIssuerId")
                        .HasColumnType("int")
                        .HasColumnName("InvoiceIssuerID");

                    b.Property<int?>("ItemCount")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<DateTime?>("PaymentDeadline")
                        .HasColumnType("datetime");

                    b.Property<string>("PaymentMethod")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("PrintedCopies")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceIssuerId");

                    b.HasIndex("OrderId");

                    b.ToTable("Invoice", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.InvoiceIssuer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BankAccount")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TaxIdentifier")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("InvoiceIssuer", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.InvoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int")
                        .HasColumnName("InvoiceID");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OrderItemId")
                        .HasColumnType("int")
                        .HasColumnName("OrderItemID");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Vatpercentage")
                        .HasColumnType("int")
                        .HasColumnName("VATPercentage");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("OrderItemId");

                    b.ToTable("InvoiceItem", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CustomerSiteId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerSiteID");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("datetime");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentMethodID");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("StatusID");

                    b.HasKey("Id");

                    b.HasIndex("CustomerSiteId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("StatusId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("StatusID");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StatusId");

                    b.ToTable("OrderItem", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Deadline")
                        .HasColumnType("int");

                    b.Property<string>("Method")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<string>("Description")
                        .HasColumnType("xml");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("Vatid")
                        .HasColumnType("int")
                        .HasColumnName("VATID");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Vatid");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Status", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.Vat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Percentage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VAT", (string)null);
                });

            modelBuilder.Entity("ExampleCollection.Entities.Category", b =>
                {
                    b.HasOne("ExampleCollection.Entities.Category", "ParentCategory")
                        .WithMany("InverseParentCategory")
                        .HasForeignKey("ParentCategoryId")
                        .HasConstraintName("FK__Category__Parent__2A4B4B5E");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Customer", b =>
                {
                    b.HasOne("ExampleCollection.Entities.CustomerSite", "MainCustomerSite")
                        .WithMany("Customers")
                        .HasForeignKey("MainCustomerSiteId")
                        .HasConstraintName("Customer_MainCustomerSite");

                    b.Navigation("MainCustomerSite");
                });

            modelBuilder.Entity("ExampleCollection.Entities.CustomerSite", b =>
                {
                    b.HasOne("ExampleCollection.Entities.Customer", "MainCustomer")
                        .WithMany("CustomerSites")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__CustomerS__Custo__32E0915F");

                    b.Navigation("MainCustomer");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Invoice", b =>
                {
                    b.HasOne("ExampleCollection.Entities.InvoiceIssuer", "InvoiceIssuer")
                        .WithMany("Invoices")
                        .HasForeignKey("InvoiceIssuerId")
                        .HasConstraintName("FK__Invoice__Invoice__4222D4EF");

                    b.HasOne("ExampleCollection.Entities.Order", "Order")
                        .WithMany("Invoices")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__Invoice__OrderID__4316F928");

                    b.Navigation("InvoiceIssuer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ExampleCollection.Entities.InvoiceItem", b =>
                {
                    b.HasOne("ExampleCollection.Entities.Invoice", "Invoice")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK__InvoiceIt__Invoi__45F365D3");

                    b.HasOne("ExampleCollection.Entities.OrderItem", "OrderItem")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("OrderItemId")
                        .HasConstraintName("FK__InvoiceIt__Order__46E78A0C");

                    b.Navigation("Invoice");

                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Order", b =>
                {
                    b.HasOne("ExampleCollection.Entities.CustomerSite", "CustomerSite")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerSiteId")
                        .HasConstraintName("FK__Order__CustomerS__36B12243");

                    b.HasOne("ExampleCollection.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentMethodId")
                        .HasConstraintName("FK__Order__PaymentMe__38996AB5");

                    b.HasOne("ExampleCollection.Entities.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK__Order__StatusID__37A5467C");

                    b.Navigation("CustomerSite");

                    b.Navigation("PaymentMethod");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ExampleCollection.Entities.OrderItem", b =>
                {
                    b.HasOne("ExampleCollection.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__OrderItem__Order__3B75D760");

                    b.HasOne("ExampleCollection.Entities.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__OrderItem__Produ__3C69FB99");

                    b.HasOne("ExampleCollection.Entities.Status", "Status")
                        .WithMany("OrderItems")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK__OrderItem__Statu__3D5E1FD2");

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Product", b =>
                {
                    b.HasOne("ExampleCollection.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Product__Categor__2E1BDC42");

                    b.HasOne("ExampleCollection.Entities.Vat", "Vat")
                        .WithMany("Products")
                        .HasForeignKey("Vatid")
                        .HasConstraintName("FK__Product__VATID__2D27B809");

                    b.Navigation("Category");

                    b.Navigation("Vat");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Category", b =>
                {
                    b.Navigation("InverseParentCategory");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Customer", b =>
                {
                    b.Navigation("CustomerSites");
                });

            modelBuilder.Entity("ExampleCollection.Entities.CustomerSite", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Invoice", b =>
                {
                    b.Navigation("InvoiceItems");
                });

            modelBuilder.Entity("ExampleCollection.Entities.InvoiceIssuer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Order", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ExampleCollection.Entities.OrderItem", b =>
                {
                    b.Navigation("InvoiceItems");
                });

            modelBuilder.Entity("ExampleCollection.Entities.PaymentMethod", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Product", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Status", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ExampleCollection.Entities.Vat", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
