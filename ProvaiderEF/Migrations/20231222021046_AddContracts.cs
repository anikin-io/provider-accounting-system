using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaiderEF.Migrations
{
    /// <inheritdoc />
    public partial class AddContracts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Subscribers_SubscriberId",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Tariffs_TariffId",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Contract_ContractId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Contract_ContractId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Contract_ContractId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Contract_ContractId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Contract_ContractId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_ContractId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ContractId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contract",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Contract",
                newName: "Contracts");

            migrationBuilder.RenameIndex(
                name: "IX_Contract_TariffId",
                table: "Contracts",
                newName: "IX_Contracts_TariffId");

            migrationBuilder.RenameIndex(
                name: "IX_Contract_SubscriberId",
                table: "Contracts",
                newName: "IX_Contracts_SubscriberId");

            migrationBuilder.AlterColumn<int>(
                name: "ContractId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contracts",
                table: "Contracts",
                column: "ContractId");

            migrationBuilder.CreateTable(
                name: "ContractEmployee",
                columns: table => new
                {
                    ContractsContractId = table.Column<int>(type: "int", nullable: false),
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractEmployee", x => new { x.ContractsContractId, x.EmployeesEmployeeId });
                    table.ForeignKey(
                        name: "FK_ContractEmployee_Contracts_ContractsContractId",
                        column: x => x.ContractsContractId,
                        principalTable: "Contracts",
                        principalColumn: "ContractId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractEmployee_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractEquipment",
                columns: table => new
                {
                    ContractsContractId = table.Column<int>(type: "int", nullable: false),
                    EquipmentsEquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractEquipment", x => new { x.ContractsContractId, x.EquipmentsEquipmentId });
                    table.ForeignKey(
                        name: "FK_ContractEquipment_Contracts_ContractsContractId",
                        column: x => x.ContractsContractId,
                        principalTable: "Contracts",
                        principalColumn: "ContractId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractEquipment_Equipments_EquipmentsEquipmentId",
                        column: x => x.EquipmentsEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContractEmployee_EmployeesEmployeeId",
                table: "ContractEmployee",
                column: "EmployeesEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractEquipment_EquipmentsEquipmentId",
                table: "ContractEquipment",
                column: "EquipmentsEquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Subscribers_SubscriberId",
                table: "Contracts",
                column: "SubscriberId",
                principalTable: "Subscribers",
                principalColumn: "SubscriberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Tariffs_TariffId",
                table: "Contracts",
                column: "TariffId",
                principalTable: "Tariffs",
                principalColumn: "TariffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Contracts_ContractId",
                table: "Events",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Contracts_ContractId",
                table: "Invoices",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "ContractId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Contracts_ContractId",
                table: "Transactions",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "ContractId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Subscribers_SubscriberId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Tariffs_TariffId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Contracts_ContractId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Contracts_ContractId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Contracts_ContractId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "ContractEmployee");

            migrationBuilder.DropTable(
                name: "ContractEquipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contracts",
                table: "Contracts");

            migrationBuilder.RenameTable(
                name: "Contracts",
                newName: "Contract");

            migrationBuilder.RenameIndex(
                name: "IX_Contracts_TariffId",
                table: "Contract",
                newName: "IX_Contract_TariffId");

            migrationBuilder.RenameIndex(
                name: "IX_Contracts_SubscriberId",
                table: "Contract",
                newName: "IX_Contract_SubscriberId");

            migrationBuilder.AlterColumn<int>(
                name: "ContractId",
                table: "Transactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Equipments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contract",
                table: "Contract",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_ContractId",
                table: "Equipments",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ContractId",
                table: "Employees",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Subscribers_SubscriberId",
                table: "Contract",
                column: "SubscriberId",
                principalTable: "Subscribers",
                principalColumn: "SubscriberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Tariffs_TariffId",
                table: "Contract",
                column: "TariffId",
                principalTable: "Tariffs",
                principalColumn: "TariffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Contract_ContractId",
                table: "Employees",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Contract_ContractId",
                table: "Equipments",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Contract_ContractId",
                table: "Events",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Contract_ContractId",
                table: "Invoices",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "ContractId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Contract_ContractId",
                table: "Transactions",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "ContractId");
        }
    }
}
