using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesProject.Models
{
    public class RecipeReview
    {
        [Key]public int Id { get; set; }

        public string UserName { get; set; }

        //[Required(ErrorMessage = "Please enter your review")]
        public string Comment { get; set; }

        [ForeignKey("RecipeId")]
        public int RecipeId { get; set; }

        public int Rating { get; set; }
    }
}
