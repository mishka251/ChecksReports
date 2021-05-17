using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckReport.Migrations
{
    public partial class fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Orders_OrderId",
                table: "ProductInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Products_ProductId",
                table: "ProductInOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder");

            migrationBuilder.RenameTable(
                name: "ProductInOrder",
                newName: "ProductsInOrders");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrder_ProductId",
                table: "ProductsInOrders",
                newName: "IX_ProductsInOrders_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsInOrders",
                table: "ProductsInOrders",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsInOrders_Orders_OrderId",
                table: "ProductsInOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsInOrders_Products_ProductId",
                table: "ProductsInOrders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsInOrders_Orders_OrderId",
                table: "ProductsInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsInOrders_Products_ProductId",
                table: "ProductsInOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsInOrders",
                table: "ProductsInOrders");

            migrationBuilder.RenameTable(
                name: "ProductsInOrders",
                newName: "ProductInOrder");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsInOrders_ProductId",
                table: "ProductInOrder",
                newName: "IX_ProductInOrder_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Orders_OrderId",
                table: "ProductInOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Products_ProductId",
                table: "ProductInOrder",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
