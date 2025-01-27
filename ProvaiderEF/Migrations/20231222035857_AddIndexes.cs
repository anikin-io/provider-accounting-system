using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaiderEF.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneSubscriber",
                table: "Subscribers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestStatus",
                table: "Requests",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PotentialSubscribers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_PhoneSubscriber",
                table: "Subscribers",
                column: "PhoneSubscriber");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestDate",
                table: "Requests",
                column: "RequestDate");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestStatus",
                table: "Requests",
                column: "RequestStatus");

            migrationBuilder.CreateIndex(
                name: "IX_PotentialSubscribers_PhoneNumber",
                table: "PotentialSubscribers",
                column: "PhoneNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Subscribers_PhoneSubscriber",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Requests_RequestDate",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_RequestStatus",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_PotentialSubscribers_PhoneNumber",
                table: "PotentialSubscribers");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneSubscriber",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestStatus",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PotentialSubscribers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
