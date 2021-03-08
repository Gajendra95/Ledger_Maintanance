using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spindle_Ledger.Data.Migrations
{
    public partial class CRUD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Product_Name = table.Column<string>(nullable: false),
                    Product_Description = table.Column<string>(nullable: false),
                    Product_Cost = table.Column<string>(nullable: false),
                    Product_Quantity = table.Column<string>(nullable: false),
                    Customer_Name = table.Column<string>(nullable: false),
                    Customer_Address = table.Column<string>(nullable: false),
                    Customer_Contact = table.Column<string>(nullable: false),
                    Seller_Name = table.Column<string>(nullable: true),
                    Seller_Address = table.Column<string>(nullable: false),
                    Seller_Contact = table.Column<string>(nullable: false),
                    WareHouse_Name = table.Column<string>(nullable: false),
                    WareHouse_Address = table.Column<string>(nullable: false),
                    WareHouse_Cost = table.Column<string>(nullable: false),
                    WareHouse_Contact = table.Column<string>(nullable: false),
                    TransportFromSeller_Name = table.Column<string>(nullable: false),
                    TransportFromSeller_Description = table.Column<string>(nullable: false),
                    TransportFromSeller_Cost = table.Column<string>(nullable: false),
                    TransportFromSeller_Contact = table.Column<string>(nullable: false),
                    TransportFromSeller_Date = table.Column<DateTime>(nullable: false),
                    TransportToCustomer_Name = table.Column<string>(nullable: false),
                    TransportToCustomer_Description = table.Column<string>(nullable: false),
                    TransportToCustomer_Cost = table.Column<string>(nullable: false),
                    TransportToCustomer_Contact = table.Column<string>(nullable: false),
                    TransportToCustomer_Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
