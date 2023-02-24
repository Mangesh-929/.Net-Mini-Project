using CRUDApp.Data;
using CRUDApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;
        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Products.ToList();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                var pro = new Product()
                {
                    productName = model.productName,
                    price=model.price,
                    prodDesc=model.prodDesc
                };
                context.Products.Add(pro);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Empty Field cannot be submit";
                return View(model);
            }
               
        }
        public IActionResult DeleteProduct(int id)
        {
            var pro = context.Products.SingleOrDefault(p => p.productId == id);
            context.Products.Remove(pro);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult UpdateProduct(int id)
        {
            var pro = context.Products.SingleOrDefault(p => p.productId == id);
            var result = new Product()
            {
                productId = pro.productId,
                productName = pro.productName,
                price = pro.price,
                prodDesc = pro.prodDesc
            };
            return View(result);
        }
        
        [HttpPost]
        public IActionResult UpdateProduct(Product model)
        {
            var pro = new Product()
            {
                productId=model.productId,
                productName = model.productName,
                price = model.price,
                prodDesc = model.prodDesc
            };
            context.Products.Update(pro);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
