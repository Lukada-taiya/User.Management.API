using System.ComponentModel.DataAnnotations;

namespace User.Management.API.Models.Authentication.Signup
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; } 
    }
}
