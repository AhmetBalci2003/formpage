using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace formpage.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Otel_Rezervasyonlar",
                columns: table => new
                {
                    RezervasyonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtelID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Giris_tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cıkıs_tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rezervasyondurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otel_Rezervasyonlar", x => x.RezervasyonId);
                });

            migrationBuilder.CreateTable(
                name: "Oteller",
                columns: table => new
                {
                    OtelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no1 = table.Column<bool>(type: "bit", nullable: false),
                    No_1_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_1_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no1_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no2 = table.Column<bool>(type: "bit", nullable: false),
                    No_2_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_2_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no2_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no3 = table.Column<bool>(type: "bit", nullable: false),
                    No_3_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_3_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no3_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no4 = table.Column<bool>(type: "bit", nullable: false),
                    No_4_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_4_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no4_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no5 = table.Column<bool>(type: "bit", nullable: false),
                    No_5_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_5_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no5_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no6 = table.Column<bool>(type: "bit", nullable: false),
                    No_6_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_6_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no6_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no7 = table.Column<bool>(type: "bit", nullable: false),
                    No_7_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_7_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no7_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no8 = table.Column<bool>(type: "bit", nullable: false),
                    No_8_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_8_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no8_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no9 = table.Column<bool>(type: "bit", nullable: false),
                    No_9_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_9_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no9_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no10 = table.Column<bool>(type: "bit", nullable: false),
                    No_10_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_10_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no10_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no11 = table.Column<bool>(type: "bit", nullable: false),
                    No_11_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_11_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no11_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no12 = table.Column<bool>(type: "bit", nullable: false),
                    No_12_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_12_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no12_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no13 = table.Column<bool>(type: "bit", nullable: false),
                    No_13_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_13_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no13_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no14 = table.Column<bool>(type: "bit", nullable: false),
                    No_14_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_14_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no14_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no15 = table.Column<bool>(type: "bit", nullable: false),
                    No_15_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_15_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no15_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no16 = table.Column<bool>(type: "bit", nullable: false),
                    No_16_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_16_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no16_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no17 = table.Column<bool>(type: "bit", nullable: false),
                    No_17_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_17_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no17_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no18 = table.Column<bool>(type: "bit", nullable: false),
                    No_18_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_18_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no18_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no19 = table.Column<bool>(type: "bit", nullable: false),
                    No_19_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_19_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no19_user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oda_no20 = table.Column<bool>(type: "bit", nullable: false),
                    No_20_giris = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_20_cıkıs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oda_no20_user = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oteller", x => x.OtelID);
                });

            migrationBuilder.CreateTable(
                name: "Otobus",
                columns: table => new
                {
                    Otobus_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sofor_adı_soyadı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firma_adı = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otobus", x => x.Otobus_Id);
                });

            migrationBuilder.CreateTable(
                name: "Otobus_rezervasyon",
                columns: table => new
                {
                    RezervasyonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    User_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeferId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltukno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rezervasyondurumu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otobus_rezervasyon", x => x.RezervasyonId);
                });

            migrationBuilder.CreateTable(
                name: "Seferler",
                columns: table => new
                {
                    SeferId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Baslangıc_sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varıs_sehri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    baslangıc_tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    varıs_tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    otobus_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sefer_durumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fiyat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_1 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_1user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_2 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_2user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_3 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_3user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_4 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_4user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_5 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_5user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_6 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_6user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_7 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_7user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_8 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_8user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_9 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_9user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_10 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_10user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_11 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_11user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_12 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_12user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_13 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_13user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_14 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_14user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_15 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_15user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_16 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_16user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_17 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_17user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_18 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_18user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_19 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_19user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_20 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_20user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_21 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_21user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_22 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_22user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_23 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_23user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_24 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_24user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_25 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_25user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_26 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_26user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_27 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_27user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_28 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_28user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_29 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_29user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_30 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_30user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_31 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_31user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_32 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_32user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_33 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_33user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_34 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_34user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_35 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_35user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_36 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_36user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_37 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_37user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_38 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_38user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_39 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_39user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltuk_40 = table.Column<bool>(type: "bit", nullable: false),
                    koltuk_40user = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seferler", x => x.SeferId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reg_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Account_Status = table.Column<bool>(type: "bit", nullable: false),
                    Phone_Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    verify_email = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Otel_Rezervasyonlar");

            migrationBuilder.DropTable(
                name: "Oteller");

            migrationBuilder.DropTable(
                name: "Otobus");

            migrationBuilder.DropTable(
                name: "Otobus_rezervasyon");

            migrationBuilder.DropTable(
                name: "Seferler");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
