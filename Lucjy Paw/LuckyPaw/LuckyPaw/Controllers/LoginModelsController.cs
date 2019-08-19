using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LuckyPaw.Data;
using LuckyPaw.Models;
using LuckyPaw.Helpers;

namespace LuckyPaw.Controllers
{
    public class LoginModelsController : Controller
    {
        private readonly LuckyPawContext _context;

        public LoginModelsController(LuckyPawContext context)
        {
            _context = context;
        }

        // GET: LoginModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoginModel.ToListAsync());
        }

        // GET: LoginModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginModel = await _context.LoginModel
                .FirstOrDefaultAsync(m => m.LoginID == id);
            if (loginModel == null)
            {
                return NotFound();
            }

            return View(loginModel);
        }

        // GET: LoginModels/Login
        public IActionResult Login()
        {
            ViewData["Page_Loading"] = "PageLoading";
            return View();
        }

        // GET: LoginModels/Login
        public IActionResult LoginOut()
        {
            return View();
        }

        // POST: Login/Login
        [HttpPost]
        public async Task<IActionResult> Login(string Username, string Password)
        {
            
            try
            {
                var registrationModel = await _context.RegistrationModel
                .FirstOrDefaultAsync(m => m.UserName == Username && m.Password == Password);

                if (registrationModel == null){
                   
                    return View(registrationModel);
                }
                else {
                    //TempData["LoggedIn"] = true;
                    //TempData["Role"] = registrationModel.Role;
            
                    return RedirectToAction("Index","Home");

                }
            }
            catch
            {
                return View();
            }
        }

        /*
        // POST: LoginModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoginID,Username,Password")] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginModel);
        }
        */

        // GET: LoginModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginModel = await _context.LoginModel.FindAsync(id);
            if (loginModel == null)
            {
                return NotFound();
            }
            return View(loginModel);
        }

        // POST: LoginModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoginID,Username,Password")] LoginModel loginModel)
        {
            if (id != loginModel.LoginID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loginModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginModelExists(loginModel.LoginID))
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
            return View(loginModel);
        }

        // GET: LoginModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginModel = await _context.LoginModel
                .FirstOrDefaultAsync(m => m.LoginID == id);
            if (loginModel == null)
            {
                return NotFound();
            }

            return View(loginModel);
        }

        // POST: LoginModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loginModel = await _context.LoginModel.FindAsync(id);
            _context.LoginModel.Remove(loginModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginModelExists(int id)
        {
            return _context.LoginModel.Any(e => e.LoginID == id);
        }
    }
}
