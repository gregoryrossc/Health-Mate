using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using HealthMate.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.Controllers
{
    public class ChartController : Controller
    {
        private HealthMateContext _context;
        public ChartController(HealthMateContext context)
        {
            this._context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index(DateTime? calendar)
        {

            IQueryable<Stats> filteredMeals;

            //if no dates selected default to current day food log
            if (!calendar.HasValue)
            {
                filteredMeals = _context.Stats.Where(u => u.Time == DateTime.Today && u.UserMatchData == User.Identity.GetUserId());
                ViewBag.selectedDate = DateTime.Today.ToString("yyyy-MM-dd");

            }
            else
            {
                filteredMeals = _context.Stats.Where(u => u.Time == calendar && u.UserMatchData == User.Identity.GetUserId());
                ViewBag.selectedDate = calendar.Value.ToString("yyyy-MM-dd");
            }

            var viewOfMeals = filteredMeals.Include(v => v.Meal);


            return View(viewOfMeals);
        }



        //DELETE
        // GET: RecentRecords/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var stats = await _context.Stats.FindAsync(id);
            return View(stats);
        }

        // POST: RecentRecords/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, [Bind("RecordId,Time,Meals,Supplements,Symptoms,Medications,UserMatchData,MealId")] Stats stats)
        {


            if (id != stats.RecordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Remove(stats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(stats);
        }





        //FLAG FOOD
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            ViewData["MealId"] = new SelectList(_context.Meals, "MealId", "MealName");

            if (id == null)
            {
                return NotFound();
            }

            var stats = await _context.Stats.FindAsync(id);

            if (stats == null)
            {
                return NotFound();
            }

            return View(stats);

        }




     
        //CREATE
        // GET: 
        public async Task<IActionResult> Create(int id)
        {
            ViewData["MealId"] = new SelectList(_context.Meals, "MealId", "MealName");
            return View(new Flags { FlagMealId = id });
        }
        

        //FLAG FOOD
        // POST
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, string Flagnotes)
        {
            _context.Flags.Add(new Flags
            {
                FlagMealId = id,
                FlagNotes = Flagnotes,
                FlagUserMatchData = User.Identity.GetUserId()

            });
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        /*
         * var newStats = new Stats
            {
                MealId = newMeal,
                Time = DateTime.Today, //try to add calendar as variable
                UserMatchData = User.Identity.GetUserId(),
                Flagged = 1
            };
        */



        /*
        public IActionResult Data()
        {
            var result = _context.Reactions
                        .GroupBy(x => new { group = x.Zone }) //[{group:1},{group:2},{group:3}]
                        .Select(group => new{                //[{Time:1, count:3},{zone:2, count:2},..]
                        
                            zone = group.Key.group,
                            //count = group.Count()
                            count = group.Count()
                        }

                ).OrderByDescending(o => o.count).ToList();
           // return Json(result);
           
            var labels = result.Select(x=>x.zone).ToArray();
            var values = result.Select(x=>x.count).ToArray();
            var max = values[0];
            List<object> list1 = new List<object>();
            list1.Add(labels);
            list1.Add(values);
            list1.Add(max);
            return Json(list1);
            
        }*/

    }
}