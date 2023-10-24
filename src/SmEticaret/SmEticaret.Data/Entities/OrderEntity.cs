namespace SmEticaret.Data.Entities
{
    public class OrderEntity : EntityBase
    {
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DeliveryAddress { get; set; }
    }
}
