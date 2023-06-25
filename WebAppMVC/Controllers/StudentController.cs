using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        //Day la 1 action trong 1 controller
        public IActionResult Index(Student s)
        {
            //Xử lí dữ liệu 
            //Truyen Model
            return View(s);
        }
        static List<Student> students = new List<Student>();
        public IActionResult Show()
        {
            //Truyen du lieu tu controller sang view
            //C1-ViewData
            ViewData["Message"] = "Truyen Du Lieu bang ViewData: ";
            ViewData["Data"] = new Student()
            {
                Code = "SV01",
                Name = "Nguyen Van A",
                Age = 20
            };
            //C2-ViewBag
            ViewBag.Message1 = "Truyen Du Lieu Bang ViewBag: ";
            ViewBag.Data1 = new Student()
            {
                Code = "SV02",
                Name = "Nguyen Van B",
                Age = 21
            };

            //Truyen mot list student sang cho view
            ViewBag.students = students;

            //C3-Model


            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost ]
        public IActionResult Add(Student s)
        {
            if(ModelState.IsValid)
            {
                students.Add(s);
                return RedirectToAction("Index",s);
                //tao va truyen model thanh cong
            }
            else
            {
                //Tao va truyen model that bai
                return View();
            }
        }
    }
}
