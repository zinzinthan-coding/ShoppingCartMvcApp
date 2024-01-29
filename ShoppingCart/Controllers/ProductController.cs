using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.DAO;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [ActionName("Index")]
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDataModel> lst = await _dbContext.Products.ToListAsync();

            return View("ProductIndex", lst);
        }

        //[HttpPost]
        //[ActionName("Create")]
        //public async Task<IActionResult> AddCart(ProductDataModel reqModel)
        //{
        //    try
        //    {
        //        var cartItem = await _dbContext.ShoppingCarts.FirstOrDefaultAsync(c => c.ProductId == reqModel.Id);
        //        if (cartItem is not null)
        //        {
        //            //cartItem.Quantity += qty;
        //        }
        //        else
        //        {
        //            var item = await _dbContext.Products.FindAsync(reqModel.Id);
        //            ShoppingCartDataModel model = new ShoppingCartDataModel()
        //            {
        //                ProductId = item!.Id,
        //                Price = item.Price,
        //              //  Quantity = qty,
        //            };
        //            _dbContext.ShoppingCarts.Add(model);
        //        }
        //        _dbContext.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }
        //    var count = await _dbContext.ShoppingCarts.CountAsync();
        //    TempData["Count"] = count.ToString();
        //    return RedirectToAction("ProductIndex");
        //}
    }
}
