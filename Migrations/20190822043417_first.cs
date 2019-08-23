using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    f_name = table.Column<string>(nullable: false),
                    l_name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    pw = table.Column<string>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Weddings",
                columns: table => new
                {
                    wedding_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    wed_one = table.Column<string>(nullable: false),
                    wed_two = table.Column<string>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weddings", x => x.wedding_id);
                    table.ForeignKey(
                        name: "FK_Weddings_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    resp_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(nullable: false),
                    wedding_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.resp_id);
                    table.ForeignKey(
                        name: "FK_Responses_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Responses_Weddings_wedding_id",
                        column: x => x.wedding_id,
                        principalTable: "Weddings",
                        principalColumn: "wedding_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_user_id",
                table: "Responses",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_wedding_id",
                table: "Responses",
                column: "wedding_id");

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_user_id",
                table: "Weddings",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Weddings");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
