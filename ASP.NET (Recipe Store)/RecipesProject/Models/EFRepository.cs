using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipesProject.Models;

namespace RecipesProject.Models
{
    public class EFRepository : IRepository
    {
        private AppDbContext context;

        public EFRepository(AppDbContext ctx) => context = ctx;

        public IQueryable<Recipe> Recipe => context.Recipes;

        public IQueryable<RecipeReview> Reviews => context.Reviews;
    }
}
