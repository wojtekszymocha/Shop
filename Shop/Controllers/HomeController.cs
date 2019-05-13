using Shop.DataAccessLayer;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private CoursesContext Db = new CoursesContext();
    
        public ActionResult Index()
        {
            var listCategory = Db.Categories.ToList();
            return View();
        }

        public ActionResult StaticSites(string name)
        {
            return View(name);
        }
    }
}