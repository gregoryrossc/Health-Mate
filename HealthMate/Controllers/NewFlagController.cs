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
    public class NewFlagController : Controller
    {
        private readonly HealthMateContext _context;

        public NewFlagController(HealthMateContext context)
        {
            _context = context;
        }


       
        [HttpGet]
        [Authorize]
        public ActionResult Index(string searching)
        {
            return View(_context.Meals.Where(x => x.MealName.Contains(searching) || searching == null));

        }

        [HttpPost]
        [Authorize]
        public ActionResult someOtherFormSubmit2(int newMeal) //calendar
        {

            var newFlags = new Flags
            {
                FlagMealId = newMeal,
                FlagUserMatchData = User.Identity.GetUserId(),
                
            };

            _context.Flags.Add(newFlags);
            _context.SaveChanges();
            return RedirectToAction("Index", "Flags");

        }








    }
}
