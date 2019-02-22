using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipesProject.Data;
using Microsoft.AspNetCore.Mvc;
using RecipesProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace RecipesProject.Controllers
{
    public class RecipesController : Controller
    {
        private readonly AppDbContext _context;

        public RecipesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("/Recipes/Index");
        }
        [Authorize]
        public IActionResult Create()
        {
            return View("/Recipes/Create");
        }
        [Authorize]
        public IActionResult Delete()
        {
            return View("/Recipes/Delete");
        }

        public IActionResult Details()
        {
            return View("/Recipes/Details");
        }
        [Authorize]
        public IActionResult Edit()
        {
            return View("/Recipes/Edit");
        }
    }
}