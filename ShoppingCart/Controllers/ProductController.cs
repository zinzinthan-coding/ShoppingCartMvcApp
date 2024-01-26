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
            
            return View("ProductIndex",lst);
        }

        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> AddCart(ProductDataModel reqModel)
        {
            List<ProductDataModel> lst = await _dbContext.Products.ToListAsync();

            return View("ProductIndex", lst);
        }
    }
}
