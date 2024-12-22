using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class User : IdentityUser<Guid>
    {
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]

        public RoleEnums.Roles Role { get; set; }
        [Required]

        public string Location { get; set; }
        public List<KiloWattPrice> Price { get; set; }
        public User(Guid userId, string userName, string email, string phoneNumber, string password, RoleEnums.Roles role, string location)
        {
            Id = userId;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            PasswordHash = password;
            Location = location;
            CreatedAt = DateTime.Now;
            LockoutEnabled = true;
            LockoutEnd = null;
            Role = role;
        }
    }
}
