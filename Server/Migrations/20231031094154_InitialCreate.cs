using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDI_kodetest.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Epost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fornavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mellomnavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etternavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobilnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reisedokumentnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fodselsdato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poststed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Land = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vedtak",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Authority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    GyldigFra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GyldigTil = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vedtak", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soknader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendtSms = table.Column<bool>(type: "bit", nullable: false),
                    KontaktId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fullmektig = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SokerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VedtakId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _rid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _self = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _etag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _attachments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _ts = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soknader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Soknader_Personer_KontaktId",
                        column: x => x.KontaktId,
                        principalTable: "Personer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Soknader_Personer_SokerId",
                        column: x => x.SokerId,
                        principalTable: "Personer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Soknader_Vedtak_VedtakId",
                        column: x => x.VedtakId,
                        principalTable: "Vedtak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Soknader_KontaktId",
                table: "Soknader",
                column: "KontaktId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Soknader_SokerId",
                table: "Soknader",
                column: "SokerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Soknader_VedtakId",
                table: "Soknader",
                column: "VedtakId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Soknader");

            migrationBuilder.DropTable(
                name: "Personer");

            migrationBuilder.DropTable(
                name: "Vedtak");
        }
    }
}
