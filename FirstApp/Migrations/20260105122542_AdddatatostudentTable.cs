using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class AdddatatostudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Address", "DOB", "Email", "StudentName" },
                values: new object[,]
                {
                    { 1, "Lahore", new DateTime(2006, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "talhahakeem.tech@gmail.com", "TALHA" },
                    { 2, "Lahore", new DateTime(2006, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "talhahakeem.tech@gmail.com", "TALHA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
