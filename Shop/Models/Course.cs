using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public string TitleOfCourse { get; set; }
        public string AuthorOfCourse { get; set; }
        public DateTime AddedDate { get; set; }
        public string NameOfPictureFile { get; set; }
        public string DescriptionOfCourse { get; set; }
        public decimal PriceOfCourse { get; set; }
        public bool Bestseller { get; set; }
        public bool Hided { get; set; }

        public Category Category { get; set; }
    }
}