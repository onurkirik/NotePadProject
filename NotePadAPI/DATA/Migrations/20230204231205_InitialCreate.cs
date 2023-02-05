using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotePadAPI.DATA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreationTime", "Title", "UpdateTime" },
                values: new object[] { 1, "1.Bot \n 2. Kot", new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9578), "Alınacaklar", new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreationTime", "Title", "UpdateTime" },
                values: new object[] { 2, "1.Ye \n 2. Dua et \n 3. Sev", new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9594), "Görevler", new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreationTime", "Title", "UpdateTime" },
                values: new object[] { 3, "1. Muş \n 2. Van \n 3. Of", new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9596), "Gez & Gör", new DateTime(2023, 2, 5, 2, 12, 5, 357, DateTimeKind.Local).AddTicks(9597) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
