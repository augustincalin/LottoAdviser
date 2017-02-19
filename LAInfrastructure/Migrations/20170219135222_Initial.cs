using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using System.IO;

namespace LAInfrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KeyName = table.Column<string>(maxLength: 50, nullable: false),
                    KeyValue = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extraction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExtractionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Number1 = table.Column<int>(nullable: false),
                    Number2 = table.Column<int>(nullable: false),
                    Number3 = table.Column<int>(nullable: false),
                    Number4 = table.Column<int>(nullable: false),
                    Number5 = table.Column<int>(nullable: false),
                    Number6 = table.Column<int>(nullable: false),
                    SpecialNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extraction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Number",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    IsSpecial = table.Column<bool>(nullable: true),
                    NotSeen = table.Column<int>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Occurencies = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Number", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExtractionId = table.Column<int>(nullable: false),
                    Factor1 = table.Column<decimal>(type: "decimal", nullable: false),
                    Factor2 = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factor_Extraction",
                        column: x => x.ExtractionId,
                        principalTable: "Extraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factor_ExtractionId",
                table: "Factor",
                column: "ExtractionId");
            
            //feed the new db with data.
            //verify this is working
            var sqlFile = Path.Combine("scripts", @"initial-data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Factor");

            migrationBuilder.DropTable(
                name: "Number");

            migrationBuilder.DropTable(
                name: "Extraction");
        }
    }
}
