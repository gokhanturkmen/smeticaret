using System.ComponentModel.DataAnnotations.Schema;

namespace SmEticaret.Data.Entities
{
    public class CartEntity : EntityBase
    {
        public int UserId { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(UserId))]
        public UserEntity User { get; set; }
    }
}
