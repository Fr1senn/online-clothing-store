using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineClothingStore.Migrations
{
    /// <inheritdoc />
    public partial class ReviewColumnsChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "review",
                table: "reviews",
                newName: "comment");

            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "comment",
                table: "reviews",
                newName: "review");

            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "reviews",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
