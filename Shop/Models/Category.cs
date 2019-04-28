using System.Collections;
using System.Collections.Generic;

namespace Shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string NameOfCategory { get; set; }
        public string DescriptionOfCategory { get; set; }
        public string NameOfIconFile { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}