using FoodRecipes.Data;
using FoodRecipes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDashes([FromQuery] int count)
        {
            FoodRecipesContext context = new FoodRecipesContext();

            Food food = new Food()
            {
                Name = "Fra5",
                Price = 10
            };

            if (!context.Foods.Any())
                return NotFound();
            return Ok(context.Foods.Take(count));
        }
    }
}
