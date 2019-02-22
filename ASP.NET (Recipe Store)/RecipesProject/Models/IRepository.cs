using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesProject.Models
{
    public interface IRepository
    {
        IQueryable<Recipe> Recipe { get; }

        IQueryable<RecipeReview> Reviews { get; }
    }
}
