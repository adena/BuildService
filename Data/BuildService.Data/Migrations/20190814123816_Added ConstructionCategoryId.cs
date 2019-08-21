using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildService.Data.Migrations
{
    public partial class AddedConstructionCategoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ConstructionCategoryId",
                table: "ConstructionWorks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ConstructionCategoryId",
                table: "ConstructionWorks",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
