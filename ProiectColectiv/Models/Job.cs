using System.Collections.Generic;

namespace ProiectColectiv.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class Job
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime PostedOn { get; set; }

        [Required]
        public DateTime AvailableUntil { get; set; }

        public virtual List<Contract> Contracts { get; set; }

        public virtual List<Recommendation> Recommendations { get; set; }
    }
}
