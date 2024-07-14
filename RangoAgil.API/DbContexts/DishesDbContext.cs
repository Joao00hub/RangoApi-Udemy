using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Entities;

namespace RangoAgil.API.DbContexts
{
    public class DishesDbContext : DbContext
    {
        public DishesDbContext(DbContextOptions<DishesDbContext> options) : base(options)
        {
        }

        public DbSet<Dishe> Dishes { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
                new { Id = 1, Name = "Carne de Vaca" },
                new { Id = 2, Name = "Cebola" },
                new { Id = 3, Name = "Cerveja Escura" },
                new { Id = 4, Name = "Fatia de Pão Integral" },
                new { Id = 5, Name = "Mostarda" },
                new { Id = 6, Name = "Chicória" },
                new { Id = 7, Name = "Maionese" },
                new { Id = 8, Name = "Vários Temperos" },
                new { Id = 9, Name = "Mexilhões" },
                new { Id = 10, Name = "Aipo" },
                new { Id = 11, Name = "Batatas Fritas" },
                new { Id = 12, Name = "Tomate" },
                new { Id = 13, Name = "Extrato de Tomate" },
                new { Id = 14, Name = "Folha de Louro" },
                new { Id = 15, Name = "Cenoura" },
                new { Id = 16, Name = "Alho" },
                new { Id = 17, Name = "Vinho Tinto" },
                new { Id = 18, Name = "Leite de Coco" },
                new { Id = 19, Name = "Gengibre" },
                new { Id = 20, Name = "Pimenta Malagueta" },
                new { Id = 21, Name = "Tamarindo" },
                new { Id = 22, Name = "Peixe Firme" },
                new { Id = 23, Name = "Pasta de Gengibre e Alho" },
                new { Id = 24, Name = "Garam Masala" }
            );

            modelBuilder.Entity<Dishe>().HasData(
                new { Id = 1, Name = "Ensopado Flamengo de Carne de Vaca com Chicória" },
                new { Id = 2, Name = "Mexilhões com Batatas Fritas" },
                new { Id = 3, Name = "Ragu alla Bolognese" },
                new { Id = 4, Name = "Rendang" },
                new { Id = 5, Name = "Masala de Peixe" }
            );

            modelBuilder
                .Entity<Dishe>()
                .HasMany(d => d.Ingredients)
                .WithMany(i => i.Dishes)
                .UsingEntity<Dictionary<string, object>>(
                    "DisheIngredient",
                    j => j.HasData(
                        new { DishesId = 1, IngredientsId = 1 },
                        new { DishesId = 1, IngredientsId = 2 },
                        new { DishesId = 1, IngredientsId = 3 },
                        new { DishesId = 1, IngredientsId = 4 },
                        new { DishesId = 1, IngredientsId = 5 },
                        new { DishesId = 1, IngredientsId = 6 },
                        new { DishesId = 1, IngredientsId = 7 },
                        new { DishesId = 1, IngredientsId = 8 },
                        new { DishesId = 1, IngredientsId = 14 },
                        new { DishesId = 2, IngredientsId = 9 },
                        new { DishesId = 2, IngredientsId = 19 },
                        new { DishesId = 2, IngredientsId = 11 },
                        new { DishesId = 2, IngredientsId = 12 },
                        new { DishesId = 2, IngredientsId = 13 },
                        new { DishesId = 2, IngredientsId = 2 },
                        new { DishesId = 2, IngredientsId = 21 },
                        new { DishesId = 2, IngredientsId = 8 },
                        new { DishesId = 3, IngredientsId = 1 },
                        new { DishesId = 3, IngredientsId = 12 },
                        new { DishesId = 3, IngredientsId = 17 },
                        new { DishesId = 3, IngredientsId = 14 },
                        new { DishesId = 3, IngredientsId = 2 },
                        new { DishesId = 3, IngredientsId = 16 },
                        new { DishesId = 3, IngredientsId = 23 },
                        new { DishesId = 3, IngredientsId = 8 },
                        new { DishesId = 4, IngredientsId = 1 },
                        new { DishesId = 4, IngredientsId = 18 },
                        new { DishesId = 4, IngredientsId = 16 },
                        new { DishesId = 4, IngredientsId = 20 },
                        new { DishesId = 4, IngredientsId = 22 },
                        new { DishesId = 4, IngredientsId = 2 },
                        new { DishesId = 4, IngredientsId = 21 },
                        new { DishesId = 4, IngredientsId = 8 },
                        new { DishesId = 5, IngredientsId = 24 },
                        new { DishesId = 5, IngredientsId = 10 },
                        new { DishesId = 5, IngredientsId = 23 },
                        new { DishesId = 5, IngredientsId = 2 },
                        new { DishesId = 5, IngredientsId = 12 },
                        new { DishesId = 5, IngredientsId = 18 },
                        new { DishesId = 5, IngredientsId = 14 },
                        new { DishesId = 5, IngredientsId = 20 },
                        new { DishesId = 5, IngredientsId = 13 }
                    )
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
