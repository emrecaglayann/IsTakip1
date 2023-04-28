using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Data.Migrations
{
    public partial class _1001_Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yetkili = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YetkiliTelefon = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepoRaf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoRaf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DurusTip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DurusTip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IsDosya",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsDosya", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KalinlikId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KalinlikId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailParametreleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSLKullan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailParametreleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriKisitlama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kisitlama = table.Column<bool>(type: "bit", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriKisitlama", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriTemsilcisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoyAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNumarasi = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriTemsilcisi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepoDepoRaf",
                columns: table => new
                {
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    DepoRafId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoDepoRaf", x => new { x.DepoId, x.DepoRafId });
                    table.ForeignKey(
                        name: "FK_DepoDepoRaf_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoDepoRaf_DepoRaf_DepoRafId",
                        column: x => x.DepoRafId,
                        principalTable: "DepoRaf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepoEnvanter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    DepoRafId = table.Column<int>(type: "int", nullable: false),
                    MalzemeTipiId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    En = table.Column<int>(type: "int", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Agirlik = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriId = table.Column<int>(type: "int", nullable: true),
                    KalinliklarIdId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoEnvanter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepoEnvanter_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanter_KalinlikId_KalinliklarIdId",
                        column: x => x.KalinliklarIdId,
                        principalTable: "KalinlikId",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriSinifId = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VergiNumarasi = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: true),
                    MusteriKisitlamaId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteri_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Musteri_MusteriKisitlama_MusteriKisitlamaId",
                        column: x => x.MusteriKisitlamaId,
                        principalTable: "MusteriKisitlama",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ajanda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusteriTemsilcisiId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ajanda_MusteriTemsilcisi_MusteriTemsilcisiId",
                        column: x => x.MusteriTemsilcisiId,
                        principalTable: "MusteriTemsilcisi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DepoTedarikci",
                columns: table => new
                {
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    TedarikciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoTedarikci", x => new { x.DepoId, x.TedarikciId });
                    table.ForeignKey(
                        name: "FK_DepoTedarikci_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoTedarikci_Tedarikci_TedarikciId",
                        column: x => x.TedarikciId,
                        principalTable: "Tedarikci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MalzemeTip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepoEnvanterId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalzemeTip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MalzemeTip_DepoEnvanter_DepoEnvanterId",
                        column: x => x.DepoEnvanterId,
                        principalTable: "DepoEnvanter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Is",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Teklifli = table.Column<bool>(type: "bit", nullable: false),
                    TeklifNo = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<int>(type: "int", nullable: false),
                    IsBitimindeBildir = table.Column<bool>(type: "bit", nullable: false),
                    Termin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnceliği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriSiparisNo = table.Column<int>(type: "int", nullable: false),
                    IsNotu = table.Column<int>(type: "int", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    Iscilik = table.Column<bool>(type: "bit", nullable: false),
                    MalzemeNotu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnceligi = table.Column<int>(type: "int", nullable: false),
                    KalinliklarIdId = table.Column<int>(type: "int", nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Is", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Is_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Is_KalinlikId_KalinliklarIdId",
                        column: x => x.KalinliklarIdId,
                        principalTable: "KalinlikId",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Is_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriMusteriTemsilcisi",
                columns: table => new
                {
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    MusteriTemsilcisiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriMusteriTemsilcisi", x => new { x.MusteriId, x.MusteriTemsilcisiId });
                    table.ForeignKey(
                        name: "FK_MusteriMusteriTemsilcisi_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusteriMusteriTemsilcisi_MusteriTemsilcisi_MusteriTemsilcisiId",
                        column: x => x.MusteriTemsilcisiId,
                        principalTable: "MusteriTemsilcisi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriSinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriSinif", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriSinif_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IsIsDosya",
                columns: table => new
                {
                    IsDosyalarId = table.Column<int>(type: "int", nullable: false),
                    IsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIsDosya", x => new { x.IsDosyalarId, x.IsId });
                    table.ForeignKey(
                        name: "FK_IsIsDosya_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsIsDosya_IsDosya_IsDosyalarId",
                        column: x => x.IsDosyalarId,
                        principalTable: "IsDosya",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsMalzemeTip",
                columns: table => new
                {
                    IsId = table.Column<int>(type: "int", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsMalzemeTip", x => new { x.IsId, x.MalzemeTipId });
                    table.ForeignKey(
                        name: "FK_IsMalzemeTip_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsMalzemeTip_MalzemeTip_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "MalzemeTip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UretimEmri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    IsEmriTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamDurusSuresi = table.Column<TimeSpan>(type: "time", nullable: false),
                    UretimBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimTamamlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimDurum = table.Column<bool>(type: "bit", nullable: false),
                    UretimDurumlari = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimEmri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimEmri_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UretimDurus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimEmriId = table.Column<int>(type: "int", nullable: false),
                    DurusSuresi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DurusTipId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimDurus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimDurus_DurusTip_DurusTipId",
                        column: x => x.DurusTipId,
                        principalTable: "DurusTip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UretimDurus_UretimEmri_UretimEmriId",
                        column: x => x.UretimEmriId,
                        principalTable: "UretimEmri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    KullanıcıKodu = table.Column<int>(type: "int", nullable: false),
                    KullanıcıSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailBildirim = table.Column<bool>(type: "bit", nullable: false),
                    RolTanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AjandaId = table.Column<int>(type: "int", nullable: true),
                    DepoEnvanterId = table.Column<int>(type: "int", nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: true),
                    DepoRafId = table.Column<int>(type: "int", nullable: true),
                    DurusTipId = table.Column<int>(type: "int", nullable: true),
                    IsDosyaId = table.Column<int>(type: "int", nullable: true),
                    IsId = table.Column<int>(type: "int", nullable: true),
                    KalinlikIdId = table.Column<int>(type: "int", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: true),
                    MusteriKisitlamaId = table.Column<int>(type: "int", nullable: true),
                    MusteriSinifId = table.Column<int>(type: "int", nullable: true),
                    MusteriTemsilcisiId = table.Column<int>(type: "int", nullable: true),
                    TedarikciId = table.Column<int>(type: "int", nullable: true),
                    UretimDurusId = table.Column<int>(type: "int", nullable: true),
                    UretimEmriId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GüncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanici_Ajanda_AjandaId",
                        column: x => x.AjandaId,
                        principalTable: "Ajanda",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_DepoEnvanter_DepoEnvanterId",
                        column: x => x.DepoEnvanterId,
                        principalTable: "DepoEnvanter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_DepoRaf_DepoRafId",
                        column: x => x.DepoRafId,
                        principalTable: "DepoRaf",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_DurusTip_DurusTipId",
                        column: x => x.DurusTipId,
                        principalTable: "DurusTip",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_IsDosya_IsDosyaId",
                        column: x => x.IsDosyaId,
                        principalTable: "IsDosya",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_KalinlikId_KalinlikIdId",
                        column: x => x.KalinlikIdId,
                        principalTable: "KalinlikId",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_MalzemeTip_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "MalzemeTip",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanici_MusteriKisitlama_MusteriKisitlamaId",
                        column: x => x.MusteriKisitlamaId,
                        principalTable: "MusteriKisitlama",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_MusteriSinif_MusteriSinifId",
                        column: x => x.MusteriSinifId,
                        principalTable: "MusteriSinif",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_MusteriTemsilcisi_MusteriTemsilcisiId",
                        column: x => x.MusteriTemsilcisiId,
                        principalTable: "MusteriTemsilcisi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_Tedarikci_TedarikciId",
                        column: x => x.TedarikciId,
                        principalTable: "Tedarikci",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_UretimDurus_UretimDurusId",
                        column: x => x.UretimDurusId,
                        principalTable: "UretimDurus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanici_UretimEmri_UretimEmriId",
                        column: x => x.UretimEmriId,
                        principalTable: "UretimEmri",
                        principalColumn: "Id");
                });

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
                name: "IX_Ajanda_MusteriTemsilcisiId",
                table: "Ajanda",
                column: "MusteriTemsilcisiId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoDepoRaf_DepoRafId",
                table: "DepoDepoRaf",
                column: "DepoRafId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanter_DepoId",
                table: "DepoEnvanter",
                column: "DepoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanter_KalinliklarIdId",
                table: "DepoEnvanter",
                column: "KalinliklarIdId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoTedarikci_TedarikciId",
                table: "DepoTedarikci",
                column: "TedarikciId");

            migrationBuilder.CreateIndex(
                name: "IX_Is_DepoId",
                table: "Is",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Is_KalinliklarIdId",
                table: "Is",
                column: "KalinliklarIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Is_MusteriId",
                table: "Is",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIsDosya_IsId",
                table: "IsIsDosya",
                column: "IsId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMalzemeTip_MalzemeTipId",
                table: "IsMalzemeTip",
                column: "MalzemeTipId");

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
                name: "IX_Kullanici_UretimEmriId",
                table: "Kullanici",
                column: "UretimEmriId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciMailParametreleri_MailParametreleriId",
                table: "KullaniciMailParametreleri",
                column: "MailParametreleriId");

            migrationBuilder.CreateIndex(
                name: "IX_MalzemeTip_DepoEnvanterId",
                table: "MalzemeTip",
                column: "DepoEnvanterId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_DepoId",
                table: "Musteri",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_MusteriKisitlamaId",
                table: "Musteri",
                column: "MusteriKisitlamaId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriMusteriTemsilcisi_MusteriTemsilcisiId",
                table: "MusteriMusteriTemsilcisi",
                column: "MusteriTemsilcisiId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriSinif_MusteriId",
                table: "MusteriSinif",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDurus_DurusTipId",
                table: "UretimDurus",
                column: "DurusTipId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDurus_UretimEmriId",
                table: "UretimDurus",
                column: "UretimEmriId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimEmri_IsId",
                table: "UretimEmri",
                column: "IsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepoDepoRaf");

            migrationBuilder.DropTable(
                name: "DepoTedarikci");

            migrationBuilder.DropTable(
                name: "IsIsDosya");

            migrationBuilder.DropTable(
                name: "IsMalzemeTip");

            migrationBuilder.DropTable(
                name: "KullaniciMailParametreleri");

            migrationBuilder.DropTable(
                name: "MusteriMusteriTemsilcisi");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "MailParametreleri");

            migrationBuilder.DropTable(
                name: "Ajanda");

            migrationBuilder.DropTable(
                name: "DepoRaf");

            migrationBuilder.DropTable(
                name: "IsDosya");

            migrationBuilder.DropTable(
                name: "MalzemeTip");

            migrationBuilder.DropTable(
                name: "MusteriSinif");

            migrationBuilder.DropTable(
                name: "Tedarikci");

            migrationBuilder.DropTable(
                name: "UretimDurus");

            migrationBuilder.DropTable(
                name: "MusteriTemsilcisi");

            migrationBuilder.DropTable(
                name: "DepoEnvanter");

            migrationBuilder.DropTable(
                name: "DurusTip");

            migrationBuilder.DropTable(
                name: "UretimEmri");

            migrationBuilder.DropTable(
                name: "Is");

            migrationBuilder.DropTable(
                name: "KalinlikId");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Depo");

            migrationBuilder.DropTable(
                name: "MusteriKisitlama");
        }
    }
}
