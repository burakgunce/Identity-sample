using System.ComponentModel.DataAnnotations;

namespace WA_IdentityApplicationSample_080124.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        
    }
}
