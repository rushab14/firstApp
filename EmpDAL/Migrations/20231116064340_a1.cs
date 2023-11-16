using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpDAL.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Aadhaar",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "People");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "personGender",
                table: "Employees",
                newName: "Aadhar");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Isactive",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOJ",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "People");

            migrationBuilder.RenameColumn(
                name: "Aadhar",
                table: "People",
                newName: "personGender");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "People",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<bool>(
                name: "Isactive",
                table: "People",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOJ",
                table: "People",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Aadhaar",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");
        }
    }
}
