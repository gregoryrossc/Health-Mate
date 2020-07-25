using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using HealthMate.Data;
using HealthMate.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.Controllers
{
    public class FlaggedController : Controller
    {

        private readonly HealthMateContext _context;
        private ApplicationDbContext _application;


        public FlaggedController(HealthMateContext context)
        {
            _context = context;
        }
        // GET: FlaggedController
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //shows users flagged meals (Avoid duplicates)

            //flagged is going to be here
            /*
            var recentFlags =
                 (from m in _context.Meals
                  join s in _context.Stats on m.MealId equals s.MealId
                  where s.UserMatchData == User.Identity.GetUserId() && s.Flagged == 1
                  group s by s.Meal.MealName into g
                  select g.First()).Select(s => new FlaggedMeal
                  {
                      RecordId = s.RecordId,
                      MealName = s.Meal.MealName,
                      Flagged = s.Flagged,
                      Notes = s.Notes,

                  });*/



        return View(); //await recentFlags.ToListAsync()
        }






  //EDIT FLAG

  //FLAG FOOD
  // GET: RecentRecords/Edit  --- IN PROGRESS

        /*
  [Authorize]
  public async Task<IActionResult> Edit(int id)
  {
      ViewData["MealId"] = new SelectList(_context.Meals, "MealId", "MealName");

      if (id == null)
      {
          return NotFound();
      }

     
            var editFlagged = new FlaggedMeal
            {
                RecordId = id,  
            };
      
            return View(editFlagged);
        }

        //FLAG FOOD
        // POST: RecentRecords/Edit/5
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int recordId, string notes)
        {
            ViewData["MealId"] = new SelectList(_context.Meals, "MealId", "MealName");

            var record = await _context.Stats.FindAsync(recordId);
            if (record.UserMatchData != User.Identity.GetUserId())
            {
                return null;
            }

            record.Notes = notes;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        





        //**REMOVE FLAG / UN FLAG ITEM **/
        //FLAG FOOD
        // GET: RecentRecords/Edit
        /*
        [Authorize]
        public async Task<IActionResult> Unflag(int id)
        {
            ViewData["MealId"] = new SelectList(_context.Meals, "MealId", "MealName");



            var flagMealName =
                 (from m in _context.Meals
                  join s in _context.Stats on m.MealId equals s.MealId
                  where s.UserMatchData == User.Identity.GetUserId() && s.Flagged == 1 && s.RecordId == id
                  select m.MealId).SingleOrDefault();
                  

            if (id == null)
            {
                return NotFound();
            }

            var ToUnFlag = new FlaggedMeal
            {
                RecordId = id,
                MealId = flagMealName,
            };

            return View(ToUnFlag);

        }

        //FLAG FOOD
        // POST: 
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Unflag(int recordId, string notes, int flagged)
        {
            ViewData["MealId"] = new SelectList(_context.Meals, "MealId", "MealName");

            var record = await _context.Stats.FindAsync(recordId);
            if (record.UserMatchData != User.Identity.GetUserId())
            {
                return null;
            }

            record.Notes = notes;
            record.Flagged = flagged;   //not unflagging?
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        // Add new meal to flag
        [HttpPost]
        [Authorize]

        public ActionResult someOtherFormSubmit2(int newMeal) //calendar
        {

            var newStats = new Stats
            {
                MealId = newMeal,
                Time = DateTime.Today, //try to add calendar as variable
                UserMatchData = User.Identity.GetUserId(),
                Flagged = 1
            };

            _context.Stats.Add(newStats);
            _context.SaveChanges();
            return RedirectToAction("Index", "Flagged");

        }

        ---- Dont need flagged controller or need to redo ***********************************************************************
        
        */


        // GET: FlaggedController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // GET: FlaggedController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlaggedController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
