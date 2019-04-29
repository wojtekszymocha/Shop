using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Please input your First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please input your Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please input your Street")]
        [StringLength(100)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Please input your City")]
        [StringLength(100)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please input your Post Code")]
        [StringLength(6)]
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime AddedDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal OrderPrice { get; set; }

        IList<ItemOrder> ItemsOrder { get; set; }
    }

    public enum OrderStatus
    {
        New,
        Executed
    }
}