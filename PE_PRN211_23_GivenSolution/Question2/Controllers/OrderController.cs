using Microsoft.AspNetCore.Mvc;
using Question2.Models;
using System.Collections.Generic;

namespace Question2.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Order()
        {
            using(PE_PRN_23SumContext context = new PE_PRN_23SumContext())
            {
                var customers = context.Customers.ToList();
                ViewBag.Customers = customers;
                List <Order> orders = new List<Order>();
                ViewBag.orders = orders;
            }
            return View();
        }

        public IActionResult Filter(string CustomerId)
        {
            using (PE_PRN_23SumContext context2 = new PE_PRN_23SumContext())
            {
                var customers = context2.Customers.ToList();
                ViewBag.Customers = customers;
                var orders = context2.Orders.Where(o => o.CustomerId==CustomerId).ToList();
                ViewBag.orders = orders;
            }
            return View("Order");
        }
        public IActionResult Detail(int id)
        {
            using (PE_PRN_23SumContext context2 = new PE_PRN_23SumContext())
            {
                var detail = context2.OrderDetails.FirstOrDefault(o => o.OrderId == id);
                ViewBag.detail = detail;
                var order = context2.Orders.FirstOrDefault(o => o.OrderId==id);
                ViewBag.order = order;
                var employee = context2.Employees.FirstOrDefault(e => e.EmployeeId == order.EmployeeId);
                ViewBag.employee = employee;    
                var product = context2.Products.Where(p => p.OrderDetails.Contains(detail)).ToList();
                ViewBag.product = product;
                var caterogry = context2.Categories.ToList();
                ViewBag.category = caterogry;
            }
            return View();
        }
    }
}
