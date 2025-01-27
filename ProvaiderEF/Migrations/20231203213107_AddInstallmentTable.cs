using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaiderEF.Migrations
{
    /// <inheritdoc />
    public partial class AddInstallmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Installments",
                columns: table => new
                {
                    InstallmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Months = table.Column<int>(type: "int", nullable: false),
                    MonthlyPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installments", x => x.InstallmentId);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentInstallment",
                columns: table => new
                {
                    EquipmentsEquipmentId = table.Column<int>(type: "int", nullable: false),
                    InstallmentsInstallmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentInstallment", x => new { x.EquipmentsEquipmentId, x.InstallmentsInstallmentId });
                    table.ForeignKey(
                        name: "FK_EquipmentInstallment_Equipments_EquipmentsEquipmentId",
                        column: x => x.EquipmentsEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentInstallment_Installments_InstallmentsInstallmentId",
                        column: x => x.InstallmentsInstallmentId,
                        principalTable: "Installments",
                        principalColumn: "InstallmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentInstallment_InstallmentsInstallmentId",
                table: "EquipmentInstallment",
                column: "InstallmentsInstallmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentInstallment");

            migrationBuilder.DropTable(
                name: "Installments");
        }
    }
}
