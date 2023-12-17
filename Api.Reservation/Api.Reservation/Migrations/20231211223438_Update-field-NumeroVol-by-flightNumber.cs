using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Reservation.Migrations
{
    /// <inheritdoc />
    public partial class UpdatefieldNumeroVolbyflightNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroVol",
                table: "Reservations",
                newName: "flightNumber");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Changement",
                value: new DateTime(2023, 12, 11, 23, 34, 38, 101, DateTimeKind.Local).AddTicks(2696));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "flightNumber",
                table: "Reservations",
                newName: "NumeroVol");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Changement",
                value: new DateTime(2023, 12, 11, 22, 2, 51, 122, DateTimeKind.Local).AddTicks(675));
        }
    }
}
