using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmEticaret.Data.Entities
{
    public class OrderItemEntity : EntityBase
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal Paid { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(OrderId))]
        public OrderEntity Order { get; set; }

        [ForeignKey(nameof(ProductId))]
        public ProductEntity Product { get; set; }
    }
}
