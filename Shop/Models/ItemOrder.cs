namespace Shop.Models
{
    public class ItemOrder
    {
        public int ItemOrderId { get; set; }
        public int OrderId { get; set; }
        public int CourseId { get; set; }
        public int Amount { get; set; }
        public decimal PriceOfItemOrder { get; set; }

        public virtual Course Course { get; set; }
        public virtual Order Order { get; set; }
    }
}