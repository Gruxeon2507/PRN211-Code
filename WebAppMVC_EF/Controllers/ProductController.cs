using Microsoft.AspNetCore.Mvc;
using WebAppMVC_EF.Model;

namespace WebAppMVC_EF.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            using(MySaleDBContext context =new MySaleDBContext())
            {
                //Danh sach category
                ViewBag.categories =context.Categories.ToList();
                //Danh sach product
                var products = context.Products.ToList();

                return View(products);

            }


        }
        [HttpPost]
        public IActionResult Index(int cateId)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //Danh sach category
                ViewBag.categories = context.Categories.ToList();
                var products = context.Products.ToList();
                ViewBag.selectedid = 0;
                //Danh sach product
                if(cateId!=0)
                {
                    products = context.Products.Where(p => p.CategoryId == cateId).ToList();
                    //Truyen lai cateid sang cho View
                    ViewBag.selectedid = cateId;
                }
                return View(products);

            }


        }

        public IActionResult Add()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //Danh sach category
                ViewBag.categories = context.Categories.ToList();
                return View();
            }
        }
        [HttpPost]
        public IActionResult Add(Product p)
        {
            if(ModelState.IsValid)
            {
                using(MySaleDBContext ctx = new MySaleDBContext())
                {
                    ctx.Add(p);
                    ctx.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Add");
        }

        public IActionResult Delete(int id)
        {
            using(MySaleDBContext context = new MySaleDBContext())
            {
                Product p =context.Products.SingleOrDefault(p => p.ProductId == id);
                context.Products.Remove(p);
                context.SaveChanges();
                return RedirectToAction("Index");   
                
            }
        }

        public IActionResult Update(int id)
        {
            using (MySaleDBContext context = new MySaleDBContext()) 
            {
                ViewBag.categories = context.Categories.ToList();
                Product p = context.Products.SingleOrDefault(p => p.ProductId == id);
                return View(p);
            }

        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                Product p1 = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                p1.ProductName= product.ProductName;
                p1.UnitPrice= product.UnitPrice;
                p1.Image= product.Image;
                p1.UnitPrice = product.UnitPrice;
                p1.CategoryId=  product.CategoryId;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}
