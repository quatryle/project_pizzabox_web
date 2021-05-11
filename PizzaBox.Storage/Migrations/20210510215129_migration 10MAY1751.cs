using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PizzaBox.Storage.Migrations
{
    public partial class migration10MAY1751 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderID = table.Column<int>(type: "integer", nullable: false),
                    PizzaName = table.Column<string>(type: "text", nullable: true),
                    CustomID = table.Column<int>(type: "integer", nullable: false),
                    StoreID = table.Column<int>(type: "integer", nullable: false),
                    PizzaPrice = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.EntityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");
        }
    }
}
