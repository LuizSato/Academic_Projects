using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipesProject.Models;
using Microsoft.EntityFrameworkCore;

namespace RecipesProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<RecipeReview> Reviews { get; set; }
    }
}
