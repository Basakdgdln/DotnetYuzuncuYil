using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetYuzuncuYil.Repository.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 23, 0, 43, 52, 71, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 23, 0, 43, 52, 71, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 23, 0, 43, 52, 71, DateTimeKind.Local).AddTicks(7456));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 23, 0, 41, 15, 6, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 23, 0, 41, 15, 6, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 23, 0, 41, 15, 6, DateTimeKind.Local).AddTicks(7611));
        }
    }
}
