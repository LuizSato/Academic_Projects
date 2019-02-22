using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesProject.Models;

namespace RecipesProject.Controllers
{
    public class DetailsModel : PageModel
    {
        private readonly RecipesProject.Models.AppDbContext _context;

        public DetailsModel(RecipesProject.Models.AppDbContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }

        public IList<RecipeReview> Reviews { get; set; }
        //public RecipeReview RecipeReviews { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeID == id);
            //Reviews = await _context.Reviews.ToListAsync();
            Reviews = _context.Reviews.Where(p => p.RecipeId == id).ToList();
            //RecipeReviews = await _context.Reviews.FirstOrDefaultAsync(p => p.RecipeId == Recipe.RecipeID);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
