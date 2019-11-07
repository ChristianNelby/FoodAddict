using FoodAddict.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FoodAddict.Data
{

    public class RecipeService
    {
        private readonly RecipeDbContext _recipeDbContext;

        public RecipeService(RecipeDbContext recipeDbContext)
        {
            _recipeDbContext = recipeDbContext;
        }

        public Task<List<Recipe>> GetRecipes()
        {
            return _recipeDbContext.Recipe.Include(recipe => recipe.Ingredients).ToListAsync();
        }

        public async Task<Recipe> GetDetails(int? id)
        {
            if (!id.HasValue)
            {
                return null;
            }
            Recipe recipe = await _recipeDbContext.Recipe.FindAsync(id);
            _recipeDbContext.Ingredient.Where( i => i.RecipeId == id).Load();
            return recipe;
        }

        public async Task DeleteRecipe(int? id)
        {
            if (id.HasValue)
            {
                Recipe recipe = await _recipeDbContext.Recipe.FindAsync(id);
                if (recipe != null)
                {
                    _recipeDbContext.Recipe.Remove(recipe);
                    await _recipeDbContext.SaveChangesAsync();
                }
            }
        }

        public async Task EditRecipe(Recipe recipe)
        {
            Recipe r = _recipeDbContext.Recipe.Find(recipe.RecipeId);
            _recipeDbContext.Ingredient.Where(i => i.RecipeId == recipe.RecipeId).Load();
            _recipeDbContext.Ingredient.RemoveRange(r.Ingredients);
            r.Title = recipe.Title;
            r.MealSize = recipe.MealSize;
            r.MealPreparationTime = recipe.MealPreparationTime;
            r.Directions = recipe.Directions;
            r.UrlImage = recipe.UrlImage;
            if (recipe.Ingredients != null)
            {
                foreach (var ingredient in recipe.Ingredients)
                {
                    ingredient.Name = ingredient.Name == null ? ingredient.Name = "" : ingredient.Name = ingredient.Name;
                    ingredient.Unit = ingredient.Unit == null ? ingredient.Unit = "" : ingredient.Unit = ingredient.Unit;
                    ingredient.Preparations = ingredient.Preparations == null ? ingredient.Preparations = "" : ingredient.Preparations = ingredient.Preparations;
                }
                r.Ingredients = recipe.Ingredients;
            }
            else
            {
                Ingredient emptyIngredient = new Ingredient
                {
                    Name = "No Ingredients",
                    Amount = 0,
                    Unit = "",
                    Preparations = ""
                };
                r.Ingredients.Add(emptyIngredient);
            }
            _recipeDbContext.Recipe.Update(r);
            await _recipeDbContext.SaveChangesAsync();
        }

        public async Task CreateRecipe(Recipe recipe)
        {
            foreach (var ingredient in recipe.Ingredients)
            {
                ingredient.Name = ingredient.Name == null ? ingredient.Name = "" : ingredient.Name = ingredient.Name;
                ingredient.Unit = ingredient.Unit == null ? ingredient.Unit = "" : ingredient.Unit = ingredient.Unit;
                ingredient.Preparations = ingredient.Preparations == null ? ingredient.Preparations = "" : ingredient.Preparations = ingredient.Preparations;
            }
            _recipeDbContext.Recipe.Add(recipe);
            await _recipeDbContext.SaveChangesAsync();
        }
    }


}