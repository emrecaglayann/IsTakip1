using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Data.Migrations
{
    public partial class _1005_Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleTanim",
                table: "Kullanici",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleTanim",
                table: "Kullanici");
        }
    }
}
