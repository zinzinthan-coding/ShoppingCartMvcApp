using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.DAO;
using ShoppingCart.Models;
using System;

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

        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> AddCart(int id)
        {
            try
            {
                var cartItem = await _dbContext.ShoppingCarts.FirstOrDefaultAsync(c => c.ProductId == id);
                if (cartItem is not null)
                {
                    cartItem.Quantity++;
                }
                else
                {
                    ProductDataModel? item = await _dbContext.Products.FindAsync(id);
                    ShoppingCartDataModel model = new ShoppingCartDataModel()
                    {
                        ProductId = item.Id,
                        Price = item.Price,
                        Quantity = 1
                    };
                    _dbContext.ShoppingCarts.Add(model);
                }
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            var qty = await _dbContext.ShoppingCarts.SumAsync(c => c.Quantity);
            return Json(qty);
        }

        [ActionName("List")]
        public IActionResult ListCart()
        {

            var lst = (from p in _dbContext.Products
                              join c in _dbContext.ShoppingCarts on p.Id equals c.ProductId
                              select new CartListResponseModel
                              {
                                  CartId = c.Id,
                                  ProductId = p.Id,
                                  ProductName = p.ProductName,
                                  Image = p.Image,
                                  TotalPrice = p.Price * c.Quantity,
                                  Quantity = c.Quantity
                              });

            return Json(lst);
        }
    }
}
