using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LuckyPaw.Data;
using LuckyPaw.Models;

namespace LuckyPaw.Controllers
{
    public class RegistrationModelsController : Controller
    {
        private readonly LuckyPawContext _context;

        public RegistrationModelsController(LuckyPawContext context)
        {
            _context = context;
        }

        // GET: RegistrationModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistrationModel.ToListAsync());
        }

        // GET: RegistrationModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationModel = await _context.RegistrationModel
                .FirstOrDefaultAsync(m => m.RegistrationID == id);
            if (registrationModel == null)
            {
                return NotFound();
            }

            return View(registrationModel);
        }

        // GET: RegistrationModels/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: RegistrationModels/Register
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("RegistrationID,FirstName,LastName,UserName,Password,Email,PhoneNumber,Address,City,State,ZipCode,Role")] RegistrationModel registrationModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "LoginModels");
            }
            return View(registrationModel);
        }

        // GET: RegistrationModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationModel = await _context.RegistrationModel.FindAsync(id);
            if (registrationModel == null)
            {
                return NotFound();
            }
            return View(registrationModel);
        }

        // POST: RegistrationModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegistrationID,FirstName,LastName,UserName,Password,Email,PhoneNumber,Address,City,State,ZipCode,Role")] RegistrationModel registrationModel)
        {
            if (id != registrationModel.RegistrationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrationModelExists(registrationModel.RegistrationID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(registrationModel);
        }

        // GET: RegistrationModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationModel = await _context.RegistrationModel
                .FirstOrDefaultAsync(m => m.RegistrationID == id);
            if (registrationModel == null)
            {
                return NotFound();
            }

            return View(registrationModel);
        }

        // POST: RegistrationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrationModel = await _context.RegistrationModel.FindAsync(id);
            _context.RegistrationModel.Remove(registrationModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrationModelExists(int id)
        {
            return _context.RegistrationModel.Any(e => e.RegistrationID == id);
        }
    }
}
