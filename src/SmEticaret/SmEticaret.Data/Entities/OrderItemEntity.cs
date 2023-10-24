namespace SmEticaret.Data.Entities
{
    public class OrderItemEntity : EntityBase
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Paid { get; set; }
    }
}
