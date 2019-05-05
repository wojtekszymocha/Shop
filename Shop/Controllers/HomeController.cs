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
            //Category category = new Category { NameOfCategory = "asp.net mvc", NameOfIconFile = "aspNetMVC.png", DescriptionOfCategory ="description" };
            //Db.Categories.Add(category);
            //Db.SaveChanges();

            var listCategory = Db.Categories.ToList();
            return View();
        }
    }
}