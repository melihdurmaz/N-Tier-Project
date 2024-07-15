using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig321 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolum_Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yaratılmatarihi = table.Column<DateTime>(name: "yaratılma tarihi", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kredi = table.Column<int>(type: "int", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    yaratılmatarihi = table.Column<DateTime>(name: "yaratılma tarihi", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dersler_Bolumler_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolumler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ogr_Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ogr_Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    yaratılmatarihi = table.Column<DateTime>(name: "yaratılma tarihi", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Bolumler_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolumler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: true),
                    yaratılmatarihi = table.Column<DateTime>(name: "yaratılma tarihi", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogretmenler_Bolumler_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolumler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDersler",
                columns: table => new
                {
                    OgrenciDersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    yaratılmatarihi = table.Column<DateTime>(name: "yaratılma tarihi", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDersler", x => x.OgrenciDersId);
                    table.ForeignKey(
                        name: "FK_OgrenciDersler_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDersler_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OgretmenDersler",
                columns: table => new
                {
                    OgrentmenDersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretmenId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    yaratılmatarihi = table.Column<DateTime>(name: "yaratılma tarihi", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretmenDersler", x => x.OgrentmenDersId);
                    table.ForeignKey(
                        name: "FK_OgretmenDersler_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgretmenDersler_Ogretmenler_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_BolumId",
                table: "Dersler",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersler_DersId",
                table: "OgrenciDersler",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersler_OgrenciId",
                table: "OgrenciDersler",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_BolumId",
                table: "Ogrenciler",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenDersler_DersId",
                table: "OgretmenDersler",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenDersler_OgretmenId",
                table: "OgretmenDersler",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmenler_BolumId",
                table: "Ogretmenler",
                column: "BolumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrenciDersler");

            migrationBuilder.DropTable(
                name: "OgretmenDersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogretmenler");

            migrationBuilder.DropTable(
                name: "Bolumler");
        }
    }
}
