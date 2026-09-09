using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BamawWebApi.Migrations
{
    /// <inheritdoc />
    public partial class changeotpverificationmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "VerifiedAt",
                table: "OtpVerifications",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerifiedAt",
                table: "OtpVerifications");
        }
    }
}
