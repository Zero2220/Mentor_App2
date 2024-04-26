using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorInClass.Migrations
{
    /// <inheritdoc />
    public partial class IdAddedAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PricingFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PricingFeatures",
                table: "PricingFeatures",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PricingFeatures",
                table: "PricingFeatures");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PricingFeatures");
        }
    }
}
