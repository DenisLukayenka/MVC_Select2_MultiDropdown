using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public class Item
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public class MyModel
        {
            public IEnumerable<Item> AvailableItems
            {
                get
                {
                    return new[]
                    {
                        new Item { Value = 1, Text = "Item 1" },
                        new Item { Value = 2, Text = "Item 2" },
                        new Item { Value = 3, Text = "Item 3" },
                    };
                }
            }
        }

        public ActionResult Index()
        {
            return View(new MyModel());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}