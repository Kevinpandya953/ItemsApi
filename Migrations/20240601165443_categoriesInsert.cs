using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemsApi.Migrations
{
    /// <inheritdoc />
    public partial class categoriesInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                               name: "Categories",
                               columns: table => new
                               {
                                CategoryID = table.Column<int>(type: "int", nullable: false),
                                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                                },
                                constraints: table =>
                                {
                                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                                });



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

        }
    }
}
