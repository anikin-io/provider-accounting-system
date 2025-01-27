using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaiderEF.Migrations
{
    /// <inheritdoc />
    public partial class AddMasterStatistic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterStatistics",
                columns: table => new
                {
                    MasterStatisticId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinishedRequestsCount = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterStatistics", x => x.MasterStatisticId);
                    table.ForeignKey(
                        name: "FK_MasterStatistics_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterStatistics_EmployeeId",
                table: "MasterStatistics",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterStatistics");
        }
    }
}
