using Microsoft.EntityFrameworkCore.Migrations;

namespace AbpNorthwindTraders.Migrations
{
    public partial class FK_Product_Supplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppProducts_AppSuppliers_SupplierID",
                table: "AppProducts");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier",
                table: "AppProducts",
                column: "SupplierID",
                principalTable: "AppSuppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier",
                table: "AppProducts");

            migrationBuilder.AddForeignKey(
                name: "FK_AppProducts_AppSuppliers_SupplierID",
                table: "AppProducts",
                column: "SupplierID",
                principalTable: "AppSuppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
