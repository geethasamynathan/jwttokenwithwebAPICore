
using System.ComponentModel.DataAnnotations;
    namespace WebAPIwithIdenity.Models
{
    public class Signup
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }
        [Required]        
        public string ConfirmPassword { get; set; }
    }
}
