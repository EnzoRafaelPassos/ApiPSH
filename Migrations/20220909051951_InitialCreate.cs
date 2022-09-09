using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PshApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataAcesso", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, null, null, new byte[] { 213, 151, 126, 196, 178, 201, 51, 63, 45, 17, 70, 107, 154, 237, 216, 43, 157, 6, 59, 215, 117, 95, 77, 6, 14, 4, 174, 58, 192, 239, 129, 149, 9, 181, 198, 148, 252, 130, 117, 141, 92, 87, 71, 249, 172, 73, 184, 249, 151, 20, 239, 41, 103, 177, 212, 67, 106, 175, 54, 101, 188, 250, 186, 125 }, new byte[] { 53, 239, 172, 128, 104, 17, 167, 156, 235, 232, 99, 229, 238, 35, 39, 160, 247, 96, 110, 195, 89, 183, 48, 146, 82, 37, 246, 27, 51, 75, 66, 73, 219, 248, 96, 109, 55, 117, 51, 79, 139, 71, 240, 84, 70, 44, 118, 165, 66, 28, 86, 64, 132, 162, 12, 91, 69, 59, 223, 53, 221, 153, 77, 84, 22, 52, 95, 1, 248, 68, 209, 242, 205, 116, 166, 200, 56, 235, 226, 46, 136, 77, 234, 115, 24, 56, 190, 165, 254, 155, 175, 219, 153, 201, 139, 23, 59, 32, 21, 17, 247, 244, 242, 0, 115, 209, 138, 63, 78, 173, 77, 30, 168, 146, 14, 202, 133, 73, 166, 75, 149, 200, 92, 195, 233, 76, 110, 125 }, "UsuarioAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
