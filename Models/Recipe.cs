using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodAddict.Models
{


    public class Recipe
    {
        public int RecipeId { get; set; }

        [Display(Name = "Recipe Title")]
        public string Title { get; set; }

        [Display(Name = "Meal Size")]
        public int MealSize { get; set; }

        [Display(Name = "Meal Preparation time")]
        public int MealPreparationTime { get; set; }

        public string Directions { get; set; }

        [Display(Name = "Image Url")]
        public string UrlImage { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

    }

}