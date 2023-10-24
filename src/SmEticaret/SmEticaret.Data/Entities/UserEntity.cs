using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmEticaret.Data.Entities
{
    public class UserEntity : EntityBase
    {
        public int RoleId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(RoleId))]
        public RoleEntity Role { get; set; }
    }
}
