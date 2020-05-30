using System.ComponentModel.DataAnnotations;


namespace Notatki.API.Dtos
{
    public class UserForRegisterDto
   {
       [Required(ErrorMessage="User name is required")]
        public string Username { get; set; }
        [Required(ErrorMessage="Password is required")]
        [StringLength(12, MinimumLength=6, ErrorMessage="The password must be between 6 and 12 characters")]
        public string Password { get; set; }
    }
} 