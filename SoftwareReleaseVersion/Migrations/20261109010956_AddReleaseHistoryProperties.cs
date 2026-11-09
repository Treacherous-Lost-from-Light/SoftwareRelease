using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareReleaseVersion.Migrations
{
    /// <inheritdoc />
    public partial class AddReleaseHistoryProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ReleaseHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "ReleaseHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ReleaseHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "ReleaseHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ReleaseHistories");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "ReleaseHistories");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ReleaseHistories");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "ReleaseHistories");
        }
    }
}
