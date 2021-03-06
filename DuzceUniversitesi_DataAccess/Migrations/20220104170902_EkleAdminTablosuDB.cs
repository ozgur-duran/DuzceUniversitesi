using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniversitesi_DataAccess.Migrations
{
    public partial class EkleAdminTablosuDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminSifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.AdminId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminler");
        }
    }
}
