using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Miasin.Mvc.Data.Migrations
{
    public partial class AuthorPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    Created = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Created = table.Column<DateTimeOffset>(nullable: true),
                    Published = table.Column<DateTimeOffset>(nullable: true),
                    Modified = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
