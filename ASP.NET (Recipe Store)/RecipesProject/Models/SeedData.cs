using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.DependencyInjection;
using RecipesProject.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices
                .GetRequiredService<AppDbContext>();
            //context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        //RecipeID = 1,
                        RecipeName = "Caesar Salad",
                        Category = "Salads",
                        Description = "Salad with Caesar dressing",
                        Directions = "Ingredients: Vegetables, caesar dressing, parmesan cheese. Toss all ingredients together.",
                        PreparationTime = 5,
                        CookingTime = 0,
                        Yield = 5
                    },
                    new Recipe
                    {
                        RecipeName = "Sandwich",
                        Category = "Main courses",
                        Description = "Sandwich",
                        Directions = "Ingredients: Bread, spread. Spread filling on bread.",
                        PreparationTime = 5,
                        CookingTime = 0,
                        Yield = 2
                    }
                    );

                if(!context.Reviews.Any())
                {
                    context.Reviews.AddRange(
                        new RecipeReview
                        {
                            UserName = "Luiz",
                            Rating = 8,
                            Comment = "Amazing Recipe",
                            RecipeId = 1
                        }
                        );
                    
                }
                context.SaveChanges();
            }
        }
        private static string GetPicturePath(string filePath) =>
        WebRoot.WebRootPath + "/images/" + filePath;

        private static IFormFile InstantiatePictureFile(string picturePath)
        {
            IFormFile file;
            using (var stream = File.OpenRead(picturePath))
            {
                file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
                {
                    Headers = new HeaderDictionary(),
                    ContentType = "image/jpeg"
                };
            }
            return file;
        }
    }
}
