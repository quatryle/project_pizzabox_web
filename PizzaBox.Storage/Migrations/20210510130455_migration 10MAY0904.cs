using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storage.Migrations
{
    public partial class migration10MAY0904 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerEntityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreEntityId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "StoreEntityId",
                table: "Orders",
                newName: "StoresEntityId");

            migrationBuilder.RenameColumn(
                name: "CustomerEntityId",
                table: "Orders",
                newName: "CustomersEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StoreEntityId",
                table: "Orders",
                newName: "IX_Orders_StoresEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerEntityId",
                table: "Orders",
                newName: "IX_Orders_CustomersEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomersEntityId",
                table: "Orders",
                column: "CustomersEntityId",
                principalTable: "Customers",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoresEntityId",
                table: "Orders",
                column: "StoresEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomersEntityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoresEntityId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "StoresEntityId",
                table: "Orders",
                newName: "StoreEntityId");

            migrationBuilder.RenameColumn(
                name: "CustomersEntityId",
                table: "Orders",
                newName: "CustomerEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StoresEntityId",
                table: "Orders",
                newName: "IX_Orders_StoreEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomersEntityId",
                table: "Orders",
                newName: "IX_Orders_CustomerEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerEntityId",
                table: "Orders",
                column: "CustomerEntityId",
                principalTable: "Customers",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreEntityId",
                table: "Orders",
                column: "StoreEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
