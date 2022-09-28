using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tamplate.data.Migrations
{
    public partial class NovoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2e8401e1-0108-4464-aad1-55b5a8634d8f"), "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("2e8401e1-0108-4464-aad1-55b5a8634d8f"));
        }
    }
}
