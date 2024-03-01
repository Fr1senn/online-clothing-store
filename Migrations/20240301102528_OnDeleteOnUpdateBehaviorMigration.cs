using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineClothingStore.Migrations
{
    /// <inheritdoc />
    public partial class OnDeleteOnUpdateBehaviorMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "order_items_order_id_fkey",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "order_items_product_id_fkey",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "orders_user_id_fkey",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "products_category_id_fkey",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "products_discount_id_fkey",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "products_manufacturer_id_fkey",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "reviews_product_id_fkey",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "reviews_user_id_fkey",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "wish_list_product_id_fkey",
                table: "wish_list");

            migrationBuilder.DropForeignKey(
                name: "wish_list_user_id_fkey",
                table: "wish_list");

            migrationBuilder.RenameColumn(
                name: "is_acitive",
                table: "discounts",
                newName: "is_active");

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "wish_list",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "wish_list",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "role_id",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "reviews",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "reviews",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "manufacturer_id",
                table: "products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "discount_id",
                table: "products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "category_id",
                table: "products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "orders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "status_id",
                table: "orders",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "order_items",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "order_items_order_id_fkey",
                table: "order_items",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "order_items_product_id_fkey",
                table: "order_items",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "orders_user_id_fkey",
                table: "orders",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "products_category_id_fkey",
                table: "products",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "products_discount_id_fkey",
                table: "products",
                column: "discount_id",
                principalTable: "discounts",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "products_manufacturer_id_fkey",
                table: "products",
                column: "manufacturer_id",
                principalTable: "manufacturers",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "reviews_product_id_fkey",
                table: "reviews",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "reviews_user_id_fkey",
                table: "reviews",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "wish_list_product_id_fkey",
                table: "wish_list",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "wish_list_user_id_fkey",
                table: "wish_list",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "order_items_order_id_fkey",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "order_items_product_id_fkey",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "orders_user_id_fkey",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "products_category_id_fkey",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "products_discount_id_fkey",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "products_manufacturer_id_fkey",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "reviews_product_id_fkey",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "reviews_user_id_fkey",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "wish_list_product_id_fkey",
                table: "wish_list");

            migrationBuilder.DropForeignKey(
                name: "wish_list_user_id_fkey",
                table: "wish_list");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "discounts",
                newName: "is_acitive");

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "wish_list",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "wish_list",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "role_id",
                table: "users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "manufacturer_id",
                table: "products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "discount_id",
                table: "products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "category_id",
                table: "products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "orders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "status_id",
                table: "orders",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "order_items",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "order_items_order_id_fkey",
                table: "order_items",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "order_items_product_id_fkey",
                table: "order_items",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "orders_user_id_fkey",
                table: "orders",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "products_category_id_fkey",
                table: "products",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "products_discount_id_fkey",
                table: "products",
                column: "discount_id",
                principalTable: "discounts",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "products_manufacturer_id_fkey",
                table: "products",
                column: "manufacturer_id",
                principalTable: "manufacturers",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "reviews_product_id_fkey",
                table: "reviews",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "reviews_user_id_fkey",
                table: "reviews",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "wish_list_product_id_fkey",
                table: "wish_list",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "wish_list_user_id_fkey",
                table: "wish_list",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");
        }
    }
}
