using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorInClass.Migrations
{
    /// <inheritdoc />
    public partial class databaseFicing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeaturePricing");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeaturePricing",
                columns: table => new
                {
                    FeaturesId = table.Column<int>(type: "int", nullable: false),
                    PricingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturePricing", x => new { x.FeaturesId, x.PricingsId });
                    table.ForeignKey(
                        name: "FK_FeaturePricing_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeaturePricing_Pricing_PricingsId",
                        column: x => x.PricingsId,
                        principalTable: "Pricing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeaturePricing_PricingsId",
                table: "FeaturePricing",
                column: "PricingsId");
        }
    }
}
