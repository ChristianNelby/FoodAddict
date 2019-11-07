using System.ComponentModel.DataAnnotations;

namespace FoodAddict.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        [Required]
        public string Name { get; set; }

        public int Amount { get; set; }

        public string Unit { get; set; }

        public string Preparations { get; set; }

    }
}