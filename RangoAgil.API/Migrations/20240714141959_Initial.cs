using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RangoAgil.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisheIngredient",
                columns: table => new
                {
                    DishesId = table.Column<int>(type: "INTEGER", nullable: false),
                    IngredientsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisheIngredient", x => new { x.DishesId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_DisheIngredient_Dishes_DishesId",
                        column: x => x.DishesId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisheIngredient_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ensopado Flamengo de Carne de Vaca com Chicória" },
                    { 2, "Mexilhões com Batatas Fritas" },
                    { 3, "Ragu alla Bolognese" },
                    { 4, "Rendang" },
                    { 5, "Masala de Peixe" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Carne de Vaca" },
                    { 2, "Cebola" },
                    { 3, "Cerveja Escura" },
                    { 4, "Fatia de Pão Integral" },
                    { 5, "Mostarda" },
                    { 6, "Chicória" },
                    { 7, "Maionese" },
                    { 8, "Vários Temperos" },
                    { 9, "Mexilhões" },
                    { 10, "Aipo" },
                    { 11, "Batatas Fritas" },
                    { 12, "Tomate" },
                    { 13, "Extrato de Tomate" },
                    { 14, "Folha de Louro" },
                    { 15, "Cenoura" },
                    { 16, "Alho" },
                    { 17, "Vinho Tinto" },
                    { 18, "Leite de Coco" },
                    { 19, "Gengibre" },
                    { 20, "Pimenta Malagueta" },
                    { 21, "Tamarindo" },
                    { 22, "Peixe Firme" },
                    { 23, "Pasta de Gengibre e Alho" },
                    { 24, "Garam Masala" }
                });

            migrationBuilder.InsertData(
                table: "DisheIngredient",
                columns: new[] { "DishesId", "IngredientsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 14 },
                    { 2, 2 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 19 },
                    { 2, 21 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 8 },
                    { 3, 12 },
                    { 3, 14 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 23 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 8 },
                    { 4, 16 },
                    { 4, 18 },
                    { 4, 20 },
                    { 4, 21 },
                    { 4, 22 },
                    { 5, 2 },
                    { 5, 10 },
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 18 },
                    { 5, 20 },
                    { 5, 23 },
                    { 5, 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DisheIngredient_IngredientsId",
                table: "DisheIngredient",
                column: "IngredientsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisheIngredient");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
