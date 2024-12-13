using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace formpage.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Last_Log_Date",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "verify_email",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "verify_email",
                table: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "Last_Log_Date",
                table: "Users",
                type: "datetime2",
                nullable: true);
        }
    }
}
