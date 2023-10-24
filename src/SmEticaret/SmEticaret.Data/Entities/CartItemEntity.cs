using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmEticaret.Data.Entities
{
    public class CartItemEntity : EntityBase
    {
        public int CartId { get; set; }

        public int ProductId { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(CartId))]
        public CartEntity Cart { get; set; }

        [ForeignKey(nameof(ProductId))]
        public ProductEntity Product { get; set; }
    }
}
