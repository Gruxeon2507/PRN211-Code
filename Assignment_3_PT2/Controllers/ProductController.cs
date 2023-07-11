using Assignment_3_PT2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_3_PT2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Show()
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                var products = context.Products.ToList();
                var categories = context.Products.ToList();
                ViewBag.Products = products;
                ViewBag.Categories = categories;
            }
            return View();
        }
        public IActionResult ShowFilter(List<Product> products)
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                var categories = context.Products.ToList();
                ViewBag.Categories = categories;
            }
            ViewBag.Products = products;
            return View();
        }
        [HttpPost]
        public IActionResult Show(Product model)
        {
            using (MyDB3Context ctx = new MyDB3Context())
            {
                var products = ctx.Products.Where(p => p.ProductCode == model.ProductCode).ToList();
                var categories = ctx.Products.ToList();
                ViewBag.Products = products;
                ViewBag.Categories = categories;
                ViewBag.Selected = model.ProductCode;
                return View();
            }
        }
        [HttpPost]
        public IActionResult Reset()
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                var products = context.Products.ToList();
                ViewBag.Products = products;
                var categories = context.Products.ToList();
                ViewBag.Categories = categories;
            }
            return RedirectToAction("Show");
        }
        [HttpPost]
        public IActionResult Update(Product model)
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                var existingProduct = context.Products.FirstOrDefault(p => p.ProductCode == model.ProductCode);
                if (existingProduct != null)
                {
                    // Update the properties of the existing product
                    if (model.ProductName != null)
                    {
                        existingProduct.ProductName = model.ProductName;
                    }
                    if (model.Unit != null)
                    {
                        existingProduct.Unit = model.Unit;
                    }
                    if (model.Price != null)
                    {
                        existingProduct.Price = model.Price;
                    }
                    if (model.Image != null)
                    {
                        existingProduct.Image = model.Image;
                    }
                    
                    
                   
                    context.SaveChanges();
                }
            }

            return RedirectToAction("Show");
        }

        
        [HttpPost]
        public IActionResult FilterByName(Product model)
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                var products = context.Products
                    .Where(p => p.ProductName.Contains(model.ProductName))
                    .ToList();

                ViewBag.Products = products;
                var categories = context.Products.ToList();
                ViewBag.Categories = categories;
            }

            return View("ShowFilter");

        }

        
            [HttpPost]
        public IActionResult FilterByPrice(Product model,decimal OldPrice)
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                
                var products = context.Products
                    .Where(p => p.Price>=(float)OldPrice && p.Price<=model.Price)
                    .ToList();

                ViewBag.Products = products;
                var categories = context.Products.ToList();
                ViewBag.Categories = categories;
            }

            return View("ShowFilter");

        }
        
            [HttpPost]
        public IActionResult FilterByImage(Product model)
        {
            using (MyDB3Context context = new MyDB3Context())
            {
                var products = context.Products
                    .Where(p => p.Image.Contains(model.Image))
                    .ToList();

                ViewBag.Products = products;
                var categories = context.Products.ToList();
                ViewBag.Categories = categories;
            }

            return View("ShowFilter");

        }
    }
}
