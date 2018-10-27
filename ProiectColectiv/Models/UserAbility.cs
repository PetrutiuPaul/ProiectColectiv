namespace ProiectColectiv.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserAbility
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        public int AbilityId { get; set; }
        
        [ForeignKey("AbilityId")]
        public virtual Ability Ability { get; set; }
    }
}
