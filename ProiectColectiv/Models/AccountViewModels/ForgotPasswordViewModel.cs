using System.ComponentModel.DataAnnotations;

namespace ProiectColectiv.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
