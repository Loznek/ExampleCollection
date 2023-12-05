using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleCollection.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParentCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Category__Parent__2A4B4B5E",
                        column: x => x.ParentCategoryID,
                        principalTable: "Category",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "InvoiceIssuer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxIdentifier = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BankAccount = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceIssuer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Deadline = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VAT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentage = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VAT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    VATID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "xml", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Product__Categor__2E1BDC42",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Product__VATID__2D27B809",
                        column: x => x.VATID,
                        principalTable: "VAT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BankAccount = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MainCustomerSiteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSite",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZipCode = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Fax = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSite", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CustomerS__Custo__32E0915F",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deadline = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerSiteID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    PaymentMethodID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Order__CustomerS__36B12243",
                        column: x => x.CustomerSiteID,
                        principalTable: "CustomerSite",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Order__PaymentMe__38996AB5",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethod",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Order__StatusID__37A5467C",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerZipCode = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    CustomerCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerStreet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrintedCopies = table.Column<int>(type: "int", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaymentDeadline = table.Column<DateTime>(type: "datetime", nullable: true),
                    InvoiceIssuerID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ItemCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Invoice__Invoice__4222D4EF",
                        column: x => x.InvoiceIssuerID,
                        principalTable: "InvoiceIssuer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Invoice__OrderID__4316F928",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK__OrderItem__Order__3B75D760",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__OrderItem__Produ__3C69FB99",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__OrderItem__Statu__3D5E1FD2",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    VATPercentage = table.Column<int>(type: "int", nullable: true),
                    InvoiceID = table.Column<int>(type: "int", nullable: true),
                    OrderItemID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK__InvoiceIt__Invoi__45F365D3",
                        column: x => x.InvoiceID,
                        principalTable: "Invoice",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__InvoiceIt__Order__46E78A0C",
                        column: x => x.OrderItemID,
                        principalTable: "OrderItem",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryID",
                table: "Category",
                column: "ParentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_MainCustomerSiteID",
                table: "Customer",
                column: "MainCustomerSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSite_CustomerID",
                table: "CustomerSite",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_InvoiceIssuerID",
                table: "Invoice",
                column: "InvoiceIssuerID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_OrderID",
                table: "Invoice",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_InvoiceID",
                table: "InvoiceItem",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_OrderItemID",
                table: "InvoiceItem",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerSiteID",
                table: "Order",
                column: "CustomerSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentMethodID",
                table: "Order",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StatusID",
                table: "Order",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_StatusID",
                table: "OrderItem",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VATID",
                table: "Product",
                column: "VATID");

            migrationBuilder.AddForeignKey(
                name: "Customer_MainCustomerSite",
                table: "Customer",
                column: "MainCustomerSiteID",
                principalTable: "CustomerSite",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Customer_MainCustomerSite",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "InvoiceItem");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "InvoiceIssuer");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "VAT");

            migrationBuilder.DropTable(
                name: "CustomerSite");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
