using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMate.Models
{
    public partial class Stats
    {
        [Key]
        public int RecordId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Time { get; set; }
        [Column("userMatchData")]
        [StringLength(450)]
        public string UserMatchData { get; set; }
        public int? MealId { get; set; }

        [ForeignKey("MealId")]
        [InverseProperty("Stats")]
        public virtual Meals Meal { get; set; }
    }
}
