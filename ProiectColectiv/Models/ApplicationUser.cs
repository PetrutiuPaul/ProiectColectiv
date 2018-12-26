using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectColectiv.Models
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public bool IsProvider { get; set; }

        public bool IsClient { get; set; }

        public virtual List<Contract> Contracts { get; set; }

        public virtual List<Review> Reviews { get; set; }

        public virtual List<Ability> Abilities { get; set; }

        [InverseProperty("Client")]
        public virtual List<Recommendation> ClientRecommendations { get; set; }

        [InverseProperty("Provider")]
        public virtual List<Recommendation> ProviderRecommendations { get; set; }
    }
}
