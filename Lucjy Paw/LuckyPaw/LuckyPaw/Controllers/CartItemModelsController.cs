using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LuckyPaw.Data;
using LuckyPaw.Models;
using LuckyPaw.Helpers;

namespace LuckyPaw.Controllers
{
    public class CartItemModelsController : Controller
    {
        private readonly LuckyPawContext _context;

        public CartItemModelsController(LuckyPawContext context)
        {
            _context = context;
        }

        // GET: CartItemModels
        public async Task<IActionResult> Index()
        {
            // Code below copied from http://learningprogramming.net/net/asp-net-core-mvc/build-shopping-cart-with-session-in-asp-net-core-mvc/
            // and updated

            var puppyCart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "puppyCart");
            var trainingServicesCart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "trainingServicesCart");

            if(puppyCart != null && trainingServicesCart != null)
                puppyCart.AddRange(trainingServicesCart);
            //ViewBag.cart = cart;
            //ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);

            //return View(await _context.CartItemModel.ToListAsync());
            if(puppyCart != null)
             return View(puppyCart);
            else
             return View(trainingServicesCart);
        }

        // GET: AddOneToTrainingServicesCart
        public async Task<IActionResult> AddOneToTrainingServicesCart(int? id)
        {
            List<CartItemModel> cart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "trainingServicesCart");
            int index = isExistTrainingService((int)id);

            if (index != -1)
            {
                cart[index].CartQty++;

                var cartItemModel = await _context.CartItemModel
                .FirstOrDefaultAsync(m => m.TrainingServicesPriceID == id);

                if (cartItemModel == null)
                {
                    return NotFound();
                }

                cartItemModel.CartQty++;

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(cartItemModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        throw;
                    }
                }
            }

            SessionHelper.SetObjectAsJson(HttpContext.Session, "trainingServicesCart", cart);

            return RedirectToAction("Index");
        }

        // GET: AddOneToTrainingServicesCart
        public async Task<IActionResult> RemoveOneFromTrainingServicesCart(int? id)
        {
            List<CartItemModel> cart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "trainingServicesCart");
            int index = isExistTrainingService((int)id);

            if (index != -1)
            {
                cart[index].CartQty--;

                var cartItemModel = await _context.CartItemModel
                .FirstOrDefaultAsync(m => m.TrainingServicesPriceID == id);

                if (cartItemModel == null)
                {
                    return NotFound();
                }

                cartItemModel.CartQty--;

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(cartItemModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        throw;
                    }
                }
            }

            SessionHelper.SetObjectAsJson(HttpContext.Session, "trainingServicesCart", cart);

            return RedirectToAction("Index");
        }

        // GET: BuyPuppy
        public async Task<IActionResult> BuyPuppy(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Code below copied from http://learningprogramming.net/net/asp-net-core-mvc/build-shopping-cart-with-session-in-asp-net-core-mvc/
            // and updated it.

            // Get the puppy 
            var pricingPuppyModel = await _context.PricingPuppyModel.FindAsync(id);

            if (pricingPuppyModel == null)
            {
                return NotFound();
            }

            if (SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "puppyCart") == null)
            {
                List<CartItemModel> cart = new List<CartItemModel>();
                CartItemModel newCartItem = new CartItemModel { PricePuppyID = pricingPuppyModel.PricePuppyID, PricePuppyDesc = pricingPuppyModel.PricePuppyDesc,
                    PricePuppy = pricingPuppyModel.PricePuppy, TrainingServicesPriceID = -1,
                    TrainingName = "", PriceTraining = 0, CartQty = 1 };

                cart.Add(newCartItem);

                if (ModelState.IsValid)
                {
                    _context.Add(newCartItem);
                    await _context.SaveChangesAsync();
                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, "puppyCart", cart);
            }
            else
            {
                List<CartItemModel> cart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "puppyCart");
                int index = isExistPuppy((int)id);

                if (index == -1)
                {
                    CartItemModel newCartItm = new CartItemModel { PricePuppyID = pricingPuppyModel.PricePuppyID, PricePuppyDesc = pricingPuppyModel.PricePuppyDesc,
                                               PricePuppy = pricingPuppyModel.PricePuppy, TrainingServicesPriceID = -1, TrainingName = "", PriceTraining = 0, CartQty = 1};
                    cart.Add(newCartItm);

                    if (ModelState.IsValid)
                    {
                        _context.Add(newCartItm);
                        await _context.SaveChangesAsync();
                    }
                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, "puppyCart", cart);
            }

            // Delete the puppy from the pricing puppy table
            //_context.PricingPuppyModel.Remove(pricingPuppyModel);
            //await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }

        
        // GET: BuyTrainingService
        public async Task<IActionResult> BuyTrainingService(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            // Code below copied from http://learningprogramming.net/net/asp-net-core-mvc/build-shopping-cart-with-session-in-asp-net-core-mvc/
            // and updated it.

            // Get the training service
            var trainingServicesPriceModel = await _context.TrainingServicesPriceModel.FindAsync(id);

            if (trainingServicesPriceModel == null)
            {
                return NotFound();
            }

            
            if (SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "trainingServicesCart") == null)
            {
                List<CartItemModel> cart = new List<CartItemModel>();

                CartItemModel newCartItem = new CartItemModel { PricePuppyID = -1, PricePuppyDesc = "", PricePuppy = 0,
                                             TrainingServicesPriceID = trainingServicesPriceModel.TrainingServicesPriceID, TrainingName = trainingServicesPriceModel.TrainingName,
                                             PriceTraining = trainingServicesPriceModel.PriceTraining, CartQty = 1 };

                cart.Add(newCartItem);

                if (ModelState.IsValid)
                {
                    _context.Add(newCartItem);
                    await _context.SaveChangesAsync();
                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, "trainingServicesCart", cart);
            }
            else
            {
                List<CartItemModel> cart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "trainingServicesCart");
                int index = isExistTrainingService((int)id);
                if (index != -1)
                {
                    cart[index].CartQty++;

                    var cartItemModel = await _context.CartItemModel
                    .FirstOrDefaultAsync(m => m.TrainingServicesPriceID == id);

                    if (cartItemModel == null)
                    {
                        return NotFound();
                    }

                    cartItemModel.CartQty++;

                    if (ModelState.IsValid)
                    {
                        try
                        {
                            _context.Update(cartItemModel);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                           throw;
                        }
                    }
                }
                else
                {
                    CartItemModel newCartItm = new CartItemModel {PricePuppyID = -1, PricePuppyDesc = "", PricePuppy = 0,
                                               TrainingServicesPriceID = trainingServicesPriceModel.TrainingServicesPriceID, TrainingName = trainingServicesPriceModel.TrainingName,
                                               PriceTraining = trainingServicesPriceModel.PriceTraining, CartQty = 1 };

                    cart.Add(newCartItm);

                    if (ModelState.IsValid)
                    {
                        _context.Add(newCartItm);
                        await _context.SaveChangesAsync();
                    }
                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, "trainingServicesCart", cart);
            }

            return RedirectToAction("Index");

        }
        

        /*
        // GET: Remove puppy
        public async Task<IActionResult> RemovePuppy(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<CartItemModel> cart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");

            
            var cartItemModel = await _context.CartItemModel
                .FirstOrDefaultAsync(m => m.CartId == id);
            if (cartItemModel == null)
            {
                return NotFound();
            }

            return View(cartItemModel); 
        }
        */

         /*
        // GET: Remove training service
        public async Task<IActionResult> RemoveTrainingService(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<CartItemModel> cart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");

            
            var cartItemModel = await _context.CartItemModel
                .FirstOrDefaultAsync(m => m.CartId == id);
            if (cartItemModel == null)
            {
                return NotFound();
            }

            return View(cartItemModel);
        }
         */

        // GET: CartItemModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItemModel = await _context.CartItemModel
                .FirstOrDefaultAsync(m => m.CartId == id);
            if (cartItemModel == null)
            {
                return NotFound();
            }

            return View(cartItemModel);
        }

        // GET: CartItemModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartItemModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CartId,PricePuppyID,PricePuppyDesc,PricePuppy,TrainingServicesPriceID,TrainingName,PriceTraining,CartQty")] CartItemModel cartItemModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartItemModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartItemModel);
        }

        // GET: CartItemModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItemModel = await _context.CartItemModel.FindAsync(id);
            if (cartItemModel == null)
            {
                return NotFound();
            }
            return View(cartItemModel);
        }

        // POST: CartItemModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CartId,PricePuppyID,PricePuppyDesc,PricePuppy,TrainingServicesPriceID,TrainingName,PriceTraining,CartQty")] CartItemModel cartItemModel)
        {
            if (id != cartItemModel.CartId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartItemModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemModelExists(cartItemModel.CartId))
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
            return View(cartItemModel);
        }

        // GET: CartItemModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItemModel = await _context.CartItemModel
                .FirstOrDefaultAsync(m => m.CartId == id);
            if (cartItemModel == null)
            {
                return NotFound();
            }

            return View(cartItemModel);
        }

        // POST: CartItemModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartItemModel = await _context.CartItemModel.FindAsync(id);
            _context.CartItemModel.Remove(cartItemModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartItemModelExists(int id)
        {
            return _context.CartItemModel.Any(e => e.CartId == id);
        }

        // Code below copied from http://learningprogramming.net/net/asp-net-core-mvc/build-shopping-cart-with-session-in-asp-net-core-mvc/
        // and updated it.

        private int isExistPuppy(int id)
        {
            List<CartItemModel> cart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "puppyCart");

            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].PricePuppyID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        private int isExistTrainingService(int id)
        {
            List<CartItemModel> cart = SessionHelper.GetObjectFromJson<List<CartItemModel>>(HttpContext.Session, "trainingServicesCart");

            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].TrainingServicesPriceID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
