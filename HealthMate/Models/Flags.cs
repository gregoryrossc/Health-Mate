using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMate.Models
{
    public partial class Flags
    {
        [Key]
        [Column("flagId")]
        public int FlagId { get; set; }
        [Column("flagMealId")]
        public int? FlagMealId { get; set; }
        [Column("flagUserMatchData")]
        [StringLength(450)]
        public string FlagUserMatchData { get; set; }
        [Column("flagNotes")]
        public string FlagNotes { get; set; }

        [ForeignKey("FlagMealId")]
        [InverseProperty("Flags")]
        public virtual Meals FlagMeal { get; set; }
    }
}
