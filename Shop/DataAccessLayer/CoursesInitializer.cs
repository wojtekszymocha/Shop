using Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop.DataAccessLayer
{
    public class CoursesInitializer : DropCreateDatabaseAlways<CoursesContext>
    {
        protected override void Seed(CoursesContext context)
        {
            SeedCoursesData(context);
            base.Seed(context);
        }

        private void SeedCoursesData(CoursesContext context)
        {
            var categories = new List<Category>
            {
                new Category() {CategoryId =1, NameOfCategory = "asp", NameOfIconFile = "asp.png", DescriptionOfCategory = " description aps net mvc" },
                new Category() {CategoryId =2, NameOfCategory = "java", NameOfIconFile = "java.png", DescriptionOfCategory = " description java" },
                new Category() {CategoryId =3, NameOfCategory = "php", NameOfIconFile = "php.png", DescriptionOfCategory = " description php" },
                new Category() {CategoryId =4, NameOfCategory = "html", NameOfIconFile = "html.png", DescriptionOfCategory = " description html" },
                new Category() {CategoryId =5, NameOfCategory = "css", NameOfIconFile = "css.png", DescriptionOfCategory = " description css" },
                new Category() {CategoryId =6, NameOfCategory = "xml", NameOfIconFile = "xml.png", DescriptionOfCategory = " description xml" },
                new Category() {CategoryId =7, NameOfCategory = "c#", NameOfIconFile = "c#.png", DescriptionOfCategory = " description c#" }
            };

            categories.ForEach(k => context.Categories.Add(k));
            context.SaveChanges();

            var course = new List<Course>
            {
                new Course() { AuthorOfCourse="wojtek", TitleOfCourse = "ASP.NET MVC part 1", CategoryId = 1, PriceOfCourse =99, Bestseller=true, NameOfPictureFile="ASPNETMVCpart1.png", AddedDate = DateTime.Now, DescriptionOfCourse="Description of ASP.NET MVC part 1"},
                new Course() { AuthorOfCourse="wojtek", TitleOfCourse = "ASP.NET MVC part 2", CategoryId = 1, PriceOfCourse =99, Bestseller=true, NameOfPictureFile="ASPNETMVCpart2.png", AddedDate = DateTime.Now, DescriptionOfCourse="Description of ASP.NET MVC part 2"},
                new Course() { AuthorOfCourse="wojtek", TitleOfCourse = "ASP.NET MVC part 3", CategoryId = 1, PriceOfCourse =99, Bestseller=true, NameOfPictureFile="ASPNETMVCpart3.png", AddedDate = DateTime.Now, DescriptionOfCourse="Description of ASP.NET MVC part 3"},
                new Course() { AuthorOfCourse="wojtek", TitleOfCourse = "ASP.NET MVC part 4", CategoryId = 1, PriceOfCourse =99, Bestseller=true, NameOfPictureFile="ASPNETMVCpart4.png", AddedDate = DateTime.Now, DescriptionOfCourse="Description of ASP.NET MVC part 4"}
            };

            course.ForEach(k => context.Courses.Add(k));
            context.SaveChanges();

        }
    }
}