// FoodAddict.Controllers.RecipeController
using FoodAddict.Data;
using FoodAddict.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using FoodAddict.Models.RecipeViewModel;

namespace FoodAddict.Controllers
{

    public class RecipeController : Controller
    {
        private readonly RecipeService _recipeService;

        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _recipeService.GetRecipes());
        }

        public async Task<IActionResult> Details(int? id)
        {
            Recipe recipe = await _recipeService.GetDetails(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(new RecipeViewModel
            {
                RecipeId = recipe.RecipeId,
                Title = recipe.Title,
                MealSize = recipe.MealSize,
                MealPreparationTime = recipe.MealPreparationTime,
                Directions = recipe.Directions,
                UrlImage = recipe.UrlImage,
                Ingredients = recipe.Ingredients.ToList()
            });
        }

        public async Task<IActionResult> Delete(int? id)
        {
            await _recipeService.DeleteRecipe(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            Recipe recipe = await _recipeService.GetDetails(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(new RecipeViewModel
            {
                RecipeId = recipe.RecipeId,
                Title = recipe.Title,
                MealSize = recipe.MealSize,
                MealPreparationTime = recipe.MealPreparationTime,
                Directions = recipe.Directions,
                UrlImage = recipe.UrlImage,
                Ingredients = recipe.Ingredients.ToList()
            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RecipeViewModel recipeViewModel)
        {
            if (base.ModelState.IsValid)
            {
            }
            Recipe recipe = new Recipe
            {
                RecipeId = recipeViewModel.RecipeId,
                Title = recipeViewModel.Title,
                MealSize = recipeViewModel.MealSize,
                MealPreparationTime = recipeViewModel.MealPreparationTime,
                Directions = recipeViewModel.Directions,
                UrlImage = recipeViewModel.UrlImage,
                Ingredients = recipeViewModel.Ingredients
            };
            await _recipeService.EditRecipe(recipe);
            if (recipe == null)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RecipeViewModel recipeViewModel)
        {
            if (recipeViewModel == null)
            {
                return NotFound();
            }
            Recipe recipe = new Recipe
            {
                Title = recipeViewModel.Title,
                MealSize = recipeViewModel.MealSize,
                MealPreparationTime = recipeViewModel.MealPreparationTime,
                Directions = recipeViewModel.Directions,
                UrlImage = recipeViewModel.UrlImage,
                Ingredients = recipeViewModel.Ingredients
            };
            await _recipeService.CreateRecipe(recipe);
            return RedirectToAction("Index");
        }
    }

}