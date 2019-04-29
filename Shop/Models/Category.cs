using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please input Name Of Category")]
        [StringLength(100)]
        public string NameOfCategory { get; set; }
        [Required(ErrorMessage = "Please input Description Of Category")]
        public string DescriptionOfCategory { get; set; }
        public string NameOfIconFile { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}