using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
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