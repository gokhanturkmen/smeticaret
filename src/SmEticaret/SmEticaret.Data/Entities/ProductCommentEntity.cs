namespace SmEticaret.Data.Entities
{
    public class ProductCommentEntity : EntityBase
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public byte StarCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
