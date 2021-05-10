using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PizzaBox.Storage.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PresetPizzas",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Crust = table.Column<string>(type: "text", nullable: true),
                    Top1 = table.Column<string>(type: "text", nullable: true),
                    Top2 = table.Column<string>(type: "text", nullable: true),
                    Top3 = table.Column<string>(type: "text", nullable: true),
                    Top4 = table.Column<string>(type: "text", nullable: true),
                    Top5 = table.Column<string>(type: "text", nullable: true),
                    Top6 = table.Column<string>(type: "text", nullable: true),
                    Top7 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetPizzas", x => x.EntityId);
                });

            migrationBuilder.InsertData(
                table: "PresetPizzas",
                columns: new[] { "EntityId", "Crust", "Name", "Top1", "Top2", "Top3", "Top4", "Top5", "Top6", "Top7" },
                values: new object[,]
                {
                    { 1L, null, "Custom Pizza", null, null, null, null, null, null, null },
                    { 2L, "Plain", "Margherita Pizza", "Tomato Sauce", "Mozzarella Cheese", null, null, null, null, null },
                    { 3L, "Plain", "Pepperoni Pizza", "Tomato Sauce", "Mozzarella Cheese", "Pepperoni", null, null, null, null },
                    { 4L, "Plain", "Chicken Alfredo Pizza", "Alfredo Sauce", "Mozzarella Cheese", "Sausage", null, null, null, null },
                    { 5L, "Deep Dish", "Deep Dish Pizza", "Tomato Sauce", "Mozzarella Cheese", null, null, null, null, null },
                    { 6L, "Thin Crust", "Thin Crust Pizza", "Tomato Sauce", "Mozzarella Cheese", null, null, null, null, null },
                    { 7L, "Plain", "Meat Pizza", "Tomato Sauce", "Mozzarella Cheese", "Sausage", "Bacon", "Chicken", "Pepperoni", null },
                    { 8L, "Plain", "Veggie Pizza", "Tomato Sauce", "Mozzarella Cheese", "Sliced Tomato", "Mushrooms", "Onions", "Olives", "Green Peppers" },
                    { 9L, "Plain", "Four Cheese Pizza", "Tomato Sauce", "Mozzarella Cheese", "Cheddar Cheese", "Provalone Cheese", "Parmesan Cheese", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PresetPizzas");
        }
    }
}
