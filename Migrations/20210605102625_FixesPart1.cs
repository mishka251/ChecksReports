using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CheckReport.Migrations
{
    public partial class FixesPart1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "ShortName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Customers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INN",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KPP",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OKPO",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TradeDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeDepartment", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DepartmentId",
                table: "Customers",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TradeDepartment_DepartmentId",
                table: "Customers",
                column: "DepartmentId",
                principalTable: "TradeDepartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TradeDepartment_DepartmentId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "TradeDepartment");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DepartmentId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "INN",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "KPP",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "OKPO",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "Customers",
                newName: "FirstName");
        }
    }
}
