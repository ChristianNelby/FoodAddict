// FoodAddict.Models.SeedData
using FoodAddict.Data;
using FoodAddict.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodAddict.Models
{

    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (RecipeDbContext context = new RecipeDbContext(serviceProvider.GetRequiredService<DbContextOptions<RecipeDbContext>>()))
            {
                if (!context.Recipe.Any())
                {
                    context.Recipe.AddRange(new Recipe
                    {
                        Title = "Knuste kartofler med hvidløg og parmesan",
                        MealSize = 4,
                        MealPreparationTime = 40,
                        Directions = "Kom kartofler og salt i en gryde og kog dem til de er lige akkurat møre.\n\nHæld vandet fra og fordel kartoflerne på en bageplade med bagepapir. Giv alle kartoflerne et tryk, så de bliver knust, men ikke mast.\n\nSmelt smør og rør presset hvidløgsfed i smørret. Pensl alle kartoflerne med en smule hvidløgssmør på hver. Drys timian over, lidt salt og peber og derefter friskrevet parmesanost.\n\nSæt kartoflerne i en forvarmet ovn ved 180 grader varmluft og bag til de er flot sprøde og gyldne på overfladen – det tager cirka 15-20 minutter.",
                        UrlImage = "https://www.valdemarsro.dk/wp-content/2019/10/knuste-kartofler.jpg",
                        Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "kartofler",
                            Amount = 1,
                            Unit = "kg",
                            Preparations = "skrubbede eller skrællede"
                        },
                        new Ingredient
                        {
                            Name = "hvidløg",
                            Amount = 3,
                            Unit = "fed",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "smør",
                            Amount = 15,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "timian",
                            Amount = 1,
                            Unit = "tsk",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "parmesan",
                            Amount = 40,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "salt",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "sort peber",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        }
                    }
                    }, new Recipe
                    {
                        Title = "Knuste kartofler med hvidløg og parmesan",
                        MealSize = 4,
                        MealPreparationTime = 40,
                        Directions = "Kom kartofler og salt i en gryde og kog dem til de er lige akkurat møre.\n\nHæld vandet fra og fordel kartoflerne på en bageplade med bagepapir. Giv alle kartoflerne et tryk, så de bliver knust, men ikke mast.\n\nSmelt smør og rør presset hvidløgsfed i smørret. Pensl alle kartoflerne med en smule hvidløgssmør på hver. Drys timian over, lidt salt og peber og derefter friskrevet parmesanost.\n\nSæt kartoflerne i en forvarmet ovn ved 180 grader varmluft og bag til de er flot sprøde og gyldne på overfladen – det tager cirka 15-20 minutter.",
                        UrlImage = "https://www.valdemarsro.dk/wp-content/2019/10/knuste-kartofler.jpg",
                        Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "kartofler",
                            Amount = 1,
                            Unit = "kg",
                            Preparations = "skrubbede eller skrællede"
                        },
                        new Ingredient
                        {
                            Name = "hvidløg",
                            Amount = 3,
                            Unit = "fed",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "smør",
                            Amount = 15,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "timian",
                            Amount = 1,
                            Unit = "tsk",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "parmesan",
                            Amount = 40,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "salt",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "sort peber",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        }
                    }
                    }, new Recipe
                    {
                        Title = "Knuste kartofler med hvidløg og parmesan",
                        MealSize = 4,
                        MealPreparationTime = 40,
                        Directions = "Kom kartofler og salt i en gryde og kog dem til de er lige akkurat møre.\n\nHæld vandet fra og fordel kartoflerne på en bageplade med bagepapir. Giv alle kartoflerne et tryk, så de bliver knust, men ikke mast.\n\nSmelt smør og rør presset hvidløgsfed i smørret. Pensl alle kartoflerne med en smule hvidløgssmør på hver. Drys timian over, lidt salt og peber og derefter friskrevet parmesanost.\n\nSæt kartoflerne i en forvarmet ovn ved 180 grader varmluft og bag til de er flot sprøde og gyldne på overfladen – det tager cirka 15-20 minutter.",
                        UrlImage = "https://www.valdemarsro.dk/wp-content/2019/10/knuste-kartofler.jpg",
                        Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "kartofler",
                            Amount = 1,
                            Unit = "kg",
                            Preparations = "skrubbede eller skrællede"
                        },
                        new Ingredient
                        {
                            Name = "hvidløg",
                            Amount = 3,
                            Unit = "fed",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "smør",
                            Amount = 15,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "timian",
                            Amount = 1,
                            Unit = "tsk",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "parmesan",
                            Amount = 40,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "salt",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "sort peber",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        }
                    }
                    }, new Recipe
                    {
                        Title = "Knuste kartofler med hvidløg og parmesan",
                        MealSize = 4,
                        MealPreparationTime = 40,
                        Directions = "Kom kartofler og salt i en gryde og kog dem til de er lige akkurat møre.\n\nHæld vandet fra og fordel kartoflerne på en bageplade med bagepapir. Giv alle kartoflerne et tryk, så de bliver knust, men ikke mast.\n\nSmelt smør og rør presset hvidløgsfed i smørret. Pensl alle kartoflerne med en smule hvidløgssmør på hver. Drys timian over, lidt salt og peber og derefter friskrevet parmesanost.\n\nSæt kartoflerne i en forvarmet ovn ved 180 grader varmluft og bag til de er flot sprøde og gyldne på overfladen – det tager cirka 15-20 minutter.",
                        UrlImage = "https://www.valdemarsro.dk/wp-content/2019/10/knuste-kartofler.jpg",
                        Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "kartofler",
                            Amount = 1,
                            Unit = "kg",
                            Preparations = "skrubbede eller skrællede"
                        },
                        new Ingredient
                        {
                            Name = "hvidløg",
                            Amount = 3,
                            Unit = "fed",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "smør",
                            Amount = 15,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "timian",
                            Amount = 1,
                            Unit = "tsk",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "parmesan",
                            Amount = 40,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "salt",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "sort peber",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        }
                    }
                    }, new Recipe
                    {
                        Title = "Knuste kartofler med hvidløg og parmesan",
                        MealSize = 4,
                        MealPreparationTime = 40,
                        Directions = "Kom kartofler og salt i en gryde og kog dem til de er lige akkurat møre.\n\nHæld vandet fra og fordel kartoflerne på en bageplade med bagepapir. Giv alle kartoflerne et tryk, så de bliver knust, men ikke mast.\n\nSmelt smør og rør presset hvidløgsfed i smørret. Pensl alle kartoflerne med en smule hvidløgssmør på hver. Drys timian over, lidt salt og peber og derefter friskrevet parmesanost.\n\nSæt kartoflerne i en forvarmet ovn ved 180 grader varmluft og bag til de er flot sprøde og gyldne på overfladen – det tager cirka 15-20 minutter.",
                        UrlImage = "https://www.valdemarsro.dk/wp-content/2019/10/knuste-kartofler.jpg",
                        Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "kartofler",
                            Amount = 1,
                            Unit = "kg",
                            Preparations = "skrubbede eller skrællede"
                        },
                        new Ingredient
                        {
                            Name = "hvidløg",
                            Amount = 3,
                            Unit = "fed",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "smør",
                            Amount = 15,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "timian",
                            Amount = 1,
                            Unit = "tsk",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "parmesan",
                            Amount = 40,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "salt",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "sort peber",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        }
                    }
                    }, new Recipe
                    {
                        Title = "Knuste kartofler med hvidløg og parmesan",
                        MealSize = 4,
                        MealPreparationTime = 40,
                        Directions = "Kom kartofler og salt i en gryde og kog dem til de er lige akkurat møre.\n\nHæld vandet fra og fordel kartoflerne på en bageplade med bagepapir. Giv alle kartoflerne et tryk, så de bliver knust, men ikke mast.\n\nSmelt smør og rør presset hvidløgsfed i smørret. Pensl alle kartoflerne med en smule hvidløgssmør på hver. Drys timian over, lidt salt og peber og derefter friskrevet parmesanost.\n\nSæt kartoflerne i en forvarmet ovn ved 180 grader varmluft og bag til de er flot sprøde og gyldne på overfladen – det tager cirka 15-20 minutter.",
                        UrlImage = "https://www.valdemarsro.dk/wp-content/2019/10/knuste-kartofler.jpg",
                        Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "kartofler",
                            Amount = 1,
                            Unit = "kg",
                            Preparations = "skrubbede eller skrællede"
                        },
                        new Ingredient
                        {
                            Name = "hvidløg",
                            Amount = 3,
                            Unit = "fed",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "smør",
                            Amount = 15,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "timian",
                            Amount = 1,
                            Unit = "tsk",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "parmesan",
                            Amount = 40,
                            Unit = "g",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "salt",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        },
                        new Ingredient
                        {
                            Name = "sort peber",
                            Amount = 0,
                            Unit = "",
                            Preparations = ""
                        }
                    }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}