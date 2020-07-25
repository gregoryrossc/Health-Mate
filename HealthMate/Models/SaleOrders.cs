using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMate.Models
{
    public partial class SaleOrders
    {
        [Key]
        [Column("Reaction_Id")]
        public int ReactionId { get; set; }
        [Column("reaction_frequency")]
        public int? ReactionFrequency { get; set; }
        [Column("reaction_severity")]
        public int? ReactionSeverity { get; set; }
    }
}
