using System.Collections.Generic;

namespace ProiectColectiv.Models
{
    using System.ComponentModel.DataAnnotations;
    
    public class Job
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual List<Contract> Contracts { get; set; }

        public virtual List<Recommendation> Recommendations { get; set; }
    }
}
