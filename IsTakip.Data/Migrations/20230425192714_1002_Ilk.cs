using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Data.Migrations
{
    public partial class _1002_Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Ajanda_AjandaId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Depo_DepoId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_DepoEnvanter_DepoEnvanterId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_DepoRaf_DepoRafId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_DurusTip_DurusTipId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Is_IsId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_IsDosya_IsDosyaId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_KalinlikId_KalinlikIdId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Kullanici_KullaniciId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_MalzemeTip_MalzemeTipId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Musteri_MusteriId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_MusteriKisitlama_MusteriKisitlamaId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_MusteriSinif_MusteriSinifId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_MusteriTemsilcisi_MusteriTemsilcisiId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Tedarikci_TedarikciId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_UretimDurus_UretimDurusId",
                table: "Kullanici");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_UretimEmri_UretimEmriId",
                table: "Kullanici");

            migrationBuilder.DropTable(
                name: "KullaniciMailParametreleri");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_AjandaId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_DepoEnvanterId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_DepoId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_DepoRafId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_DurusTipId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_IsDosyaId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_IsId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_KalinlikIdId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_KullaniciId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_MalzemeTipId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_MusteriId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_MusteriKisitlamaId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_MusteriSinifId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_MusteriTemsilcisiId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_TedarikciId",
                table: "Kullanici");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_UretimDurusId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "AjandaId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "DepoEnvanterId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "DepoId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "DepoRafId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "DurusTipId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "IsDosyaId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "IsId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "KalinlikIdId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "KullanıcıKodu",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "MalzemeTipId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "MusteriKisitlamaId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "MusteriSinifId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "MusteriTemsilcisiId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "TedarikciId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "UretimDurusId",
                table: "Kullanici");

            migrationBuilder.RenameColumn(
                name: "UretimEmriId",
                table: "Kullanici",
                newName: "MailParametreleriId");

            migrationBuilder.RenameColumn(
                name: "KullanıcıSifre",
                table: "Kullanici",
                newName: "KullaniciSifre");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanici_UretimEmriId",
                table: "Kullanici",
                newName: "IX_Kullanici_MailParametreleriId");

            migrationBuilder.AlterColumn<int>(
                name: "MusteriId",
                table: "Kullanici",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "MailBildirim",
                table: "Kullanici",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "KullaniciKodu",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_MailParametreleri_MailParametreleriId",
                table: "Kullanici",
                column: "MailParametreleriId",
                principalTable: "MailParametreleri",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_MailParametreleri_MailParametreleriId",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "KullaniciKodu",
                table: "Kullanici");

            migrationBuilder.RenameColumn(
                name: "MailParametreleriId",
                table: "Kullanici",
                newName: "UretimEmriId");

            migrationBuilder.RenameColumn(
                name: "KullaniciSifre",
                table: "Kullanici",
                newName: "KullanıcıSifre");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanici_MailParametreleriId",
                table: "Kullanici",
                newName: "IX_Kullanici_UretimEmriId");

            migrationBuilder.AlterColumn<int>(
                name: "MusteriId",
                table: "Kullanici",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "MailBildirim",
                table: "Kullanici",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AjandaId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepoEnvanterId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepoId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepoRafId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurusTipId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsDosyaId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KalinlikIdId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullanıcıKodu",
                table: "Kullanici",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MalzemeTipId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusteriKisitlamaId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusteriSinifId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusteriTemsilcisiId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TedarikciId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UretimDurusId",
                table: "Kullanici",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KullaniciMailParametreleri",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    MailParametreleriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciMailParametreleri", x => new { x.KullaniciId, x.MailParametreleriId });
                    table.ForeignKey(
                        name: "FK_KullaniciMailParametreleri_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciMailParametreleri_MailParametreleri_MailParametreleriId",
                        column: x => x.MailParametreleriId,
                        principalTable: "MailParametreleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_AjandaId",
                table: "Kullanici",
                column: "AjandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_DepoEnvanterId",
                table: "Kullanici",
                column: "DepoEnvanterId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_DepoId",
                table: "Kullanici",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_DepoRafId",
                table: "Kullanici",
                column: "DepoRafId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_DurusTipId",
                table: "Kullanici",
                column: "DurusTipId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_IsDosyaId",
                table: "Kullanici",
                column: "IsDosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_IsId",
                table: "Kullanici",
                column: "IsId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_KalinlikIdId",
                table: "Kullanici",
                column: "KalinlikIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_KullaniciId",
                table: "Kullanici",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_MalzemeTipId",
                table: "Kullanici",
                column: "MalzemeTipId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_MusteriId",
                table: "Kullanici",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_MusteriKisitlamaId",
                table: "Kullanici",
                column: "MusteriKisitlamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_MusteriSinifId",
                table: "Kullanici",
                column: "MusteriSinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_MusteriTemsilcisiId",
                table: "Kullanici",
                column: "MusteriTemsilcisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_TedarikciId",
                table: "Kullanici",
                column: "TedarikciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_UretimDurusId",
                table: "Kullanici",
                column: "UretimDurusId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciMailParametreleri_MailParametreleriId",
                table: "KullaniciMailParametreleri",
                column: "MailParametreleriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Ajanda_AjandaId",
                table: "Kullanici",
                column: "AjandaId",
                principalTable: "Ajanda",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Depo_DepoId",
                table: "Kullanici",
                column: "DepoId",
                principalTable: "Depo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_DepoEnvanter_DepoEnvanterId",
                table: "Kullanici",
                column: "DepoEnvanterId",
                principalTable: "DepoEnvanter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_DepoRaf_DepoRafId",
                table: "Kullanici",
                column: "DepoRafId",
                principalTable: "DepoRaf",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_DurusTip_DurusTipId",
                table: "Kullanici",
                column: "DurusTipId",
                principalTable: "DurusTip",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Is_IsId",
                table: "Kullanici",
                column: "IsId",
                principalTable: "Is",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_IsDosya_IsDosyaId",
                table: "Kullanici",
                column: "IsDosyaId",
                principalTable: "IsDosya",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_KalinlikId_KalinlikIdId",
                table: "Kullanici",
                column: "KalinlikIdId",
                principalTable: "KalinlikId",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Kullanici_KullaniciId",
                table: "Kullanici",
                column: "KullaniciId",
                principalTable: "Kullanici",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_MalzemeTip_MalzemeTipId",
                table: "Kullanici",
                column: "MalzemeTipId",
                principalTable: "MalzemeTip",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Musteri_MusteriId",
                table: "Kullanici",
                column: "MusteriId",
                principalTable: "Musteri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_MusteriKisitlama_MusteriKisitlamaId",
                table: "Kullanici",
                column: "MusteriKisitlamaId",
                principalTable: "MusteriKisitlama",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_MusteriSinif_MusteriSinifId",
                table: "Kullanici",
                column: "MusteriSinifId",
                principalTable: "MusteriSinif",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_MusteriTemsilcisi_MusteriTemsilcisiId",
                table: "Kullanici",
                column: "MusteriTemsilcisiId",
                principalTable: "MusteriTemsilcisi",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Tedarikci_TedarikciId",
                table: "Kullanici",
                column: "TedarikciId",
                principalTable: "Tedarikci",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_UretimDurus_UretimDurusId",
                table: "Kullanici",
                column: "UretimDurusId",
                principalTable: "UretimDurus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_UretimEmri_UretimEmriId",
                table: "Kullanici",
                column: "UretimEmriId",
                principalTable: "UretimEmri",
                principalColumn: "Id");
        }
    }
}
