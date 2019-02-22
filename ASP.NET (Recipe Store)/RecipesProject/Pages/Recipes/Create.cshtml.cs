using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecipesProject.Models;

namespace RecipesProject.Controllers
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly RecipesProject.Models.AppDbContext _context;

        public CreateModel(RecipesProject.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnPostAsync(Recipe recipe)
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //_context.Recipes.Add(Recipe);
            //await _context.SaveChangesAsync();

            //return RedirectToPage("./Index");
            if (Recipe.RecipeID == 0)
            {
                _context.Recipes.Add(recipe);
            }
            else
            {
                Recipe dbEntry = _context.Recipes.FirstOrDefault(c => c.RecipeID == recipe.RecipeID);
                if (dbEntry != null)
                {
                    dbEntry.RecipeName = recipe.RecipeName;
                    dbEntry.Category = recipe.Category;
                    dbEntry.Description = recipe.Description;
                    dbEntry.Directions = recipe.Directions;
                    dbEntry.PreparationTime = recipe.PreparationTime;
                    dbEntry.Yield = recipe.Yield;
                    dbEntry.PhotoPath = recipe.PhotoPath;
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
        //public void Save(Product product)
        //{
        //    if (product.ProductID == 0)
        //    {
        //        context.recipes.Add(product);
        //    }
        //    else
        //    {
        //        Product dbEntry = context.recipes.FirstOrDefault(c => c.ProductID == product.ProductID);
        //        if (dbEntry != null)
        //        {
        //            dbEntry.Name = product.Name;
        //            dbEntry.Description = product.Description;
        //            dbEntry.Price = product.Price;
        //            dbEntry.Category = product.Category;
        //            dbEntry.PicturePath = product.PicturePath;
        //        }
        //    }
        //    context.SaveChanges();
        //}
    }
}