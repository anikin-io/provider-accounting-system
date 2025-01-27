using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaiderEF.Migrations
{
    /// <inheritdoc />
    public partial class AddTariffArchive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TariffArchives",
                columns: table => new
                {
                    TariffArchiveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TariffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    TariffCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TariffDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffArchives", x => x.TariffArchiveId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TariffArchives");
        }
    }
}
