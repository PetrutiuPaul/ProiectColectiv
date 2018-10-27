using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectColectiv.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Contract
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        public int JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}
