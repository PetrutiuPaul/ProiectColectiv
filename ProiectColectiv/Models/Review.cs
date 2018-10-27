using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectColectiv.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0,5)]
        public int Stars { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        public int ContractId { get; set; }

        [ForeignKey("ContractId")]
        public virtual Contract Contract { get; set; }
    }
}
