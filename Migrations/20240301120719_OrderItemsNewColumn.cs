using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineClothingStore.Migrations
{
    /// <inheritdoc />
    public partial class OrderItemsNewColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "price_at_order",
                table: "order_items",
                type: "numeric(7,2)",
                precision: 7,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price_at_order",
                table: "order_items");
        }
    }
}
