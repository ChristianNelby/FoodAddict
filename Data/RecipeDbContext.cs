using FoodAddict.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAddict.Data
{


    public class RecipeDbContext : DbContext
    {
        public DbSet<Recipe> Recipe { get; set; }

        public DbSet<Ingredient> Ingredient { get; set; }

        public RecipeDbContext(DbContextOptions<RecipeDbContext> options)
            : base(options)
        {
        }
    }
}