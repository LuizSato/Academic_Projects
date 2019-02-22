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
    public class IndexModel : PageModel
    {
        private readonly RecipesProject.Models.AppDbContext _context;

        public IndexModel(RecipesProject.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }
        public string Category { get; set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipes.ToListAsync();
        }
        //public async Task<IActionResult> OnPostAsync(string cat)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Recipes.Where(p => p.Category == cat).ToList();
        //    await _context.Recipes.ToListAsync();

        //    return RedirectToPage("./Index");
        //}
        //public async Task<IActionResult> OnPostAsync(string cat)
        //{
        //    if (cat != null)
        //    {
        //        return Page();
        //    }
        //    _context.Recipes.Where(p => p.Category == cat).ToList();
        //    await _context.Recipes.ToListAsync();

        //    return RedirectToPage("./Index");
        //}

        //public async Task<IActionResult> OnGetAsync(string cat)
        //{
        //    Recipe = await _context.Recipes.ToListAsync();
        //    //if (cat == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //Recipe = _context.Recipes.Where(p => p.Category == cat).ToList();

        //    //if (Recipe == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //return Page();

        //}
        //public async  Search(string category)
        //{
        //    Recipe = _context.Recipes.Where(p => p.Category == category).ToList();
        //}

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Attach(Recipe).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!RecipeExists(Recipe.RecipeID))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return RedirectToPage("./Index");
        //}
    }
}
