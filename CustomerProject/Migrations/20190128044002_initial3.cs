using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerProject.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_Customer_Id",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_Customer_Id",
                table: "Addresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Customer_Id",
                table: "Addresses",
                column: "Customer_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_Customer_Id",
                table: "Addresses",
                column: "Customer_Id",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
