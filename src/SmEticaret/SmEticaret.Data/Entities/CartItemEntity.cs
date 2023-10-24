namespace SmEticaret.Data.Entities
{
    public class CartItemEntity : EntityBase
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
