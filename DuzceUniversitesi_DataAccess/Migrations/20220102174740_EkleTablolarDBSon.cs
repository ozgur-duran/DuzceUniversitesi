using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniversitesi_DataAccess.Migrations
{
    public partial class EkleTablolarDBSon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AkademikPersoneller",
                columns: table => new
                {
                    AkademikPersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkademikPersonelAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkademikPersonelDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AkademikPersonelDersler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkademikPersonelGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikPersoneller", x => x.AkademikPersonelId);
                });

            migrationBuilder.CreateTable(
                name: "Duyurular",
                columns: table => new
                {
                    DuyuruId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DuyuruKonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DuyuruAçıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DuyuruOlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyurular", x => x.DuyuruId);
                });

            migrationBuilder.CreateTable(
                name: "Fakulteler",
                columns: table => new
                {
                    FakulteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakulteAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakulteler", x => x.FakulteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AkademikPersoneller");

            migrationBuilder.DropTable(
                name: "Duyurular");

            migrationBuilder.DropTable(
                name: "Fakulteler");
        }
    }
}
