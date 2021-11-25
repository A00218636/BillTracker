using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BillTracker.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdCategoryID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category_ProdCategoryID",
                        column: x => x.ProdCategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminanlID = table.Column<int>(type: "int", nullable: false),
                    ProcessedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProdDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellingPrice = table.Column<double>(type: "float", nullable: false),
                    InvcDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GST = table.Column<double>(type: "float", nullable: false),
                    HST = table.Column<double>(type: "float", nullable: false),
                    PST = table.Column<double>(type: "float", nullable: false),
                    TotalTax = table.Column<double>(type: "float", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    GSTHSTRefNo = table.Column<int>(type: "int", nullable: false),
                    CustomerInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceNumber);
                    table.ForeignKey(
                        name: "FK_Invoices_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProductID",
                table: "Invoices",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProdCategoryID",
                table: "Product",
                column: "ProdCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
