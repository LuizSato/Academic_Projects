using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesProject.Models
{
    public class Recipe
    {
        [Key] public int RecipeID { get; set; }

        [Required(ErrorMessage = "Please enter a valid Title")]
        public string RecipeName { get; set; }

        [Required(ErrorMessage = "Please enter a valid Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter a valid Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter valid Directions")]
        public string Directions { get; set; }

        [Required(ErrorMessage = "Please enter a valid Preparation Time")]
        public int PreparationTime { get; set; }

        [Required(ErrorMessage = "Please enter a valid Cooking Time")]
        public int CookingTime { get; set; }

        [Required(ErrorMessage = "Please enter a valid Yield")]
        public int Yield { get; set; }

        [DisplayName("Upload File")]
        public string PhotoPath { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please enter the picture of the camera")]
        public IFormFile Picture { get; set; }

        public ICollection<RecipeReview> Reviews { get; set; }
    }
}
