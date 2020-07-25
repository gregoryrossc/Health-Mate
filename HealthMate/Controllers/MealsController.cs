using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthMate.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNet.Identity;


namespace HealthMate.Controllers
{
    public class MealsController : Controller
    {
        private readonly HealthMateContext _context;

        public MealsController(HealthMateContext context)
        {
            _context = context;
        }


        // Add new meal to food diary
        [HttpGet]
        [Authorize]
        public ActionResult Index(string searching)
        {
            return View(_context.Meals.Where(x => x.MealName.Contains(searching) || searching == null));

        }

        [HttpPost]
        [Authorize]
        public ActionResult someOtherFormSubmit(int newMeal, DateTime? calendar) //calendar
        {

            var newStats = new Stats
            {
                MealId = newMeal,
                Time = DateTime.Today, //try to add calendar as variable
                UserMatchData = User.Identity.GetUserId()
            };

            _context.Stats.Add(newStats);
            _context.SaveChanges();
            return RedirectToAction("Index", "Chart");

        }

    }
}
