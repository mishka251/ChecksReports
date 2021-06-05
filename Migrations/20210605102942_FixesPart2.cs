using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CheckReport.Migrations
{
    public partial class FixesPart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TradeDepartment_DepartmentId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TradeDepartment",
                table: "TradeDepartment");

            migrationBuilder.RenameTable(
                name: "TradeDepartment",
                newName: "TradeDepartments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TradeDepartments",
                table: "TradeDepartments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TradeDepartments_DepartmentId",
                table: "Customers",
                column: "DepartmentId",
                principalTable: "TradeDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TradeDepartments_DepartmentId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TradeDepartments",
                table: "TradeDepartments");

            migrationBuilder.RenameTable(
                name: "TradeDepartments",
                newName: "TradeDepartment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TradeDepartment",
                table: "TradeDepartment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TradeDepartment_DepartmentId",
                table: "Customers",
                column: "DepartmentId",
                principalTable: "TradeDepartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
