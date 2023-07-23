using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bonus.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index(int index,string button)
        {
            if(index == 0)
            {
                index = 1;
            }
            if (button.Equals("next"))
            {
                index = index + 1;
                if (index > 3)
                {
                    index = 1;
                }
            }
            if (button.Equals("prev"))
            {
                index = index - 1;
                if (index < 1)
                {
                    index = 3;
                }
            }
            ViewBag.index = index;
            return View();
        }
    }
}
