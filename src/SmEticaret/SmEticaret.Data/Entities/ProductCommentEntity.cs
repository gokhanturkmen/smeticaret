using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmEticaret.Data.Entities
{
    public class ProductCommentEntity : EntityBase
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }

        [Required, MaxLength(250)]
        public string Message { get; set; }

        [Required, Range(1, 5)]
        public byte StarCount { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(ProductId))]
        public ProductEntity Product { get; set; }

        [ForeignKey(nameof(UserId))]
        public UserEntity User { get; set; }
    }
}
