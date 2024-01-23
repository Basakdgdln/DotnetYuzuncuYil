using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetYuzuncuYil.Repository.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WriterSurname",
                table: "Writers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "WriterPassword",
                table: "Writers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "WriterMail",
                table: "Writers",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Surname", "UserName" },
                values: new object[] { "Balcı", "gokcebalci" });

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Surname", "UserName" },
                values: new object[] { "Yılmaz", "akinyilmaz" });

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Surname", "UserName" },
                values: new object[] { "Göktürk", "denizgokturk" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Writers");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Writers",
                newName: "WriterSurname");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Writers",
                newName: "WriterPassword");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Writers",
                newName: "WriterMail");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 4, 22, 37, 8, 580, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 4, 22, 37, 8, 580, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "BlogCreateDate",
                value: new DateTime(2024, 1, 4, 22, 37, 8, 580, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 1,
                column: "WriterSurname",
                value: "Balcı");

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 2,
                column: "WriterSurname",
                value: "Yılmaz");

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 3,
                column: "WriterSurname",
                value: "Göktürk");
        }
    }
}
