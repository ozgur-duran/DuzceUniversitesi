using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniversitesi_DataAccess.Migrations
{
    public partial class EkleAkademikPersonelMail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AkademikPersonelMail",
                table: "AkademikPersoneller",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AkademikPersonelMail",
                table: "AkademikPersoneller");
        }
    }
}
