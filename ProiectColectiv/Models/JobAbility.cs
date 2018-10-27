using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectColectiv.Models
{
    public class JobAbility
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }

        [Required]
        public int AbilityId { get; set; }

        [ForeignKey("AbilityId")]
        public virtual Ability Ability { get; set; }
    }
}
