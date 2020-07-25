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
    public class FlagsController : Controller
    {

        private readonly HealthMateContext _context;
        private ApplicationDbContext _application;

        public FlagsController(HealthMateContext context)
        {
            _context = context;
        }


        // GET: FlagsController
        public async Task<ActionResult> Index()    
        {


            var allFlags = _context.Flags.Include(x => x.FlagMeal).Where(x => x.FlagUserMatchData == User.Identity.GetUserId()).ToListAsync();

            return View(await allFlags);
        }

        // GET: FlagsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlagsController/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlagsController/Create
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("flagId,flagMealId,FlagUserMatchData,FlagNotes")] Flags flags)  
        {

            if (ModelState.IsValid)
            {

               
                flags.FlagUserMatchData = User.Identity.GetUserId();



                _context.Add(flags);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(flags);

        }

        // GET: FlagsController/Edit/5                      
        public async Task<IActionResult> Edit(int id)
        {


            if (id == null)
            {
                return NotFound();
            }

            var allFlags = _context.Flags.Include(x => x.FlagMeal).Where(x => x.FlagUserMatchData == User.Identity.GetUserId() && x.FlagId == id).FirstOrDefaultAsync();

            return View(await allFlags);
        }

        // POST: FlagsController/Edit/5
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FlagId,FlagMealId,FlagUserMatchData,FlagNotes")] Flags flags)
        {


            if (id != flags.FlagId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {


                try
                {

                    _context.Update(flags);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Index));
            }

            return View(flags);

        }

        // GET: FlagsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {

            var flags = await _context.Flags.FindAsync(id);


            return View(flags);
        }

        // POST: FlagsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, [Bind("FlagId,FlagMealId,FlagUserMatchData,FlagNotes")] Flags flags)
        {

            if (id != flags.FlagId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                try
                {
                    _context.Remove(flags);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(flags);
        }
    }
}
