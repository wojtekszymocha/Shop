using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Please input Title")]
        [StringLength(100)]
        public string TitleOfCourse { get; set; }
        [Required(ErrorMessage = "Please input Author")]
        [StringLength(100)]
        public string AuthorOfCourse { get; set; }
        public DateTime AddedDate { get; set; }
        [StringLength(100)]
        public string NameOfPictureFile { get; set; }
        public string DescriptionOfCourse { get; set; }
        public decimal PriceOfCourse { get; set; }
        public bool Bestseller { get; set; }
        public bool Hided { get; set; }

        public Category Category { get; set; }
    }
}