using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmEticaret.Data.Entities
{
    public class OrderEntity : EntityBase
    {
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }

        [Required, MaxLength(250)]
        public string DeliveryAddress { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(UserId))]
        public UserEntity User { get; set; }
    }
}
