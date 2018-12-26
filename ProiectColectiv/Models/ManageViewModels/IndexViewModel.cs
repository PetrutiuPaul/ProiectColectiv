using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProiectColectiv.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }

        [Display(Name = "Provider:")]
        public bool IsProvider { get; set; }

        [Display(Name = "Client:")]
        public bool IsClient { get; set; }

        [Display(Name = "Abilities")]
        public List<Ability> Abilities { get; set; }

    }
}
